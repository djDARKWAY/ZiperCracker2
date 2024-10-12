using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip;

namespace Brute_Force_2
{
    public partial class Form1 : Form
    {
        // Places to the files being zipped after cracked
        private bool unZippedOK = false;
        private string unZippedFiles = Path.Combine(Environment.CurrentDirectory, "Cracked Files");

        // Real-time average variables
        private string password = "";
        int inicioBF, i = 1;

        // Variables for DB files
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string passwordListFilePath = "";

        // Arrays for brute force
        private readonly string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        private readonly string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string digitChars = "0123456789";
        private readonly string accentChars = "àèìòùáéíóúâêîôûãõç";
        private readonly string specialChars = "!@#$%^&*()_+-=[]{}|;:',.<>?/";

        // Variables for drag and drop functionality
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Stopwatch and attempt counter
        private Stopwatch stopwatch = new Stopwatch();
        private int totalAttempts = 0;

        // Target animation
        private int targetHeight;
        private int animationStep = 8;
        private bool isAnimating = false;

        public Form1()
        {
            InitializeComponent();
            SevenZipBase.SetLibraryPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory, "7z.dll"));

            gbxPresets.Location = gbxCustom.Location = gbxIncremental.Location;
            gbxSettings.Width = 320;
            this.Width = 344;
            this.Height = 411;
            cboType.SelectedItem = "Incremental";
            lblCurPassword.Text = "-";
            rbtRockyou.Checked = true;

            // Initialize Timer
            timerStats = new System.Windows.Forms.Timer();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter for allowed file types
                openFileDialog.Filter = "Zip and 7z Files (*.zip;*.7z)|*.zip;*.7z";
                openFileDialog.Title = "Select the protected file";

                // Check if the user selected a file and clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the file path in the text control
                    txtZip.Text = openFileDialog.FileName;
                }
            }
        }

        private async void btnAttack_Click_1(object sender, EventArgs e)
        {
            string filePath = txtZip.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Protected zip file not loaded!");
                return;
            }

            string fileExtension = Path.GetExtension(filePath);
            if (fileExtension != ".zip" && fileExtension != ".7z")
            {
                MessageBox.Show("The file must be a .zip or .7z file!");
                return;
            }

            lblStats.Text = "▼ Close stats";
            gbxSettings.Enabled = btnAttack.Enabled = false;
            pbxOpen.Visible = false;
            pbxClose.Visible = true;
            lblStats.Visible = true;
            totalAttempts = 0;
            targetHeight = 498;
            isAnimating = true;
            timerFormAnimation.Start();

            stopwatch.Reset();
            stopwatch.Start();
            timerStats.Start();

            switch (cboType.SelectedItem.ToString())
            {
                case "Incremental":
                    string chars = BuildCharacterSet();
                    if (string.IsNullOrEmpty(chars))
                    {
                        MessageBox.Show("Please select the brute force method and at least one character type!");
                        return;
                    }
                    await Task.Run(() => CrackZipFileIncremental(filePath, 1, 15, chars));
                    break;

                case "Default wordlists":
                    passwordListFilePath = GetPasswordListFilePath();
                    await Task.Run(() => CrackZipFileWithList(filePath, passwordListFilePath));
                    break;

                case "Custom files":
                    passwordListFilePath = txtCustom.Text;
                    if (string.IsNullOrEmpty(passwordListFilePath) || !File.Exists(passwordListFilePath))
                    {
                        MessageBox.Show("Custom password list file not loaded or invalid!");
                        return;
                    }
                    await Task.Run(() => CrackZipFileWithList(filePath, passwordListFilePath));
                    break;
            }

            timerStats.Stop();
            stopwatch.Stop();
            pbxClose.Visible = false;
            pbxOpen.Visible = true;
            panelStats.BackColor = Color.FromArgb(0, 58, 0);
        }

        private string GetPasswordListFilePath()
        {
            if (rbtRockyou.Checked)
                return Path.Combine(baseDirectory, "Resources", "DB", "rockyou.txt");
            if (rbt10mplt.Checked)
                return Path.Combine(baseDirectory, "Resources", "DB", "10mplt.txt");
            if (rbt1900.Checked)
                return Path.Combine(baseDirectory, "Resources", "DB", "1900-2030.txt");
            return string.Empty;
        }

        private void CrackZipFileIncremental(string filePath, int minLength, int maxLength, string chars)
        {
            bool closeLoop = false;

            foreach (var pass in GeneratePasswords(minLength, maxLength, chars))
            {
                if (closeLoop)
                    break;

                password = pass;

                try
                { UnZip(filePath, unZippedFiles, pass); }
                catch (Exception)
                { }

                if (unZippedOK)
                {
                    closeLoop = true;
                    Invoke(new Action(() => lblCurPassword.Text = $"{pass}"));
                }

                totalAttempts++;
            }
        }

        private void CrackZipFileWithList(string filePath, string passwordListFilePath)
        {
            bool closeLoop = false;

            foreach (var pass in ReadPasswordsFromFile(passwordListFilePath))
            {
                if (closeLoop)
                    break;

                password = pass;

                try
                { UnZip(filePath, unZippedFiles, pass); }
                catch (Exception)
                { }

                if (unZippedOK)
                {
                    closeLoop = true;
                    Invoke(new Action(() => lblCurPassword.Text = $"{pass}"));
                }

                totalAttempts++;
            }
        }

        private void UnZip(string zippedFilePath, string outputFolder, string password = null)
        {
            if (chkRam.Checked == false)
            {
                SevenZipExtractor zipExtractor = null;

                if (!string.IsNullOrEmpty(password))
                {
                    zipExtractor = new SevenZipExtractor(zippedFilePath, password);
                    zipExtractor.Extracting += ZipExtractor_Extracting;
                    zipExtractor.ExtractArchive(outputFolder);
                }
            }
            else
            {
                using (var zipExtractor = !string.IsNullOrEmpty(password)
                ? new SevenZipExtractor(zippedFilePath, password)
                : null)
                {
                    if (zipExtractor != null)
                    {
                        zipExtractor.Extracting += ZipExtractor_Extracting;
                        zipExtractor.ExtractArchive(outputFolder);
                    }
                }
            }
        }

        private void ZipExtractor_Extracting(object sender, ProgressEventArgs e)
        {
            unZippedOK = true;
        }

        private string BuildCharacterSet()
        {
            StringBuilder charSet = new StringBuilder();

            if (chkLower.Checked)
                charSet.Append(lowerChars);

            if (chkUpper.Checked)
                charSet.Append(upperChars);

            if (chkDigits.Checked)
                charSet.Append(digitChars);

            if (chkAccents.Checked)
                charSet.Append(accentChars);

            if (chkSpecial.Checked)
                charSet.Append(specialChars);

            return charSet.ToString();
        }

        private void timerStats_Tick(object sender, EventArgs e)
        {
            if (i < 100)
            {
                if (i == 1)
                    inicioBF = totalAttempts;
                i++;
            }
            else
            {
                lblSpeed.Text = (totalAttempts - inicioBF).ToString() + " passwords/second";
                i = 1;
            }

            lblTimer.Text = $"{stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}";
            lblTotal.Text = $"{totalAttempts}";
            lblCurPassword.Text = password;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter for allowed file types
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Select the custom password list file";

                // Check if the user selected a file and clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the file path in the text control
                    txtCustom.Text = openFileDialog.FileName;
                }
            }
        }

        private IEnumerable<string> GeneratePasswords(int minLength, int maxLength, string chars)
        {
            for (int length = minLength; length <= maxLength; length++)
            {
                foreach (var password in GeneratePasswordsRecursive(chars, length))
                {
                    yield return password;
                }
            }
        }
        private IEnumerable<string> GeneratePasswordsRecursive(string chars, int length, string current = "")
        {
            if (length == 0)
            {
                yield return current;
            }
            else
            {
                foreach (char c in chars)
                {
                    foreach (var password in GeneratePasswordsRecursive(chars, length - 1, current + c))
                    {
                        yield return password;
                    }
                }
            }
        }
        private IEnumerable<string> ReadPasswordsFromFile(string passwordFilePath)
        {
            if (!File.Exists(passwordFilePath))
            {
                MessageBox.Show("Password file not found!");
                yield break;
            }

            using (StreamReader file = new StreamReader(passwordFilePath))
            {
                string pass;
                while ((pass = file.ReadLine()) != null)
                {
                    yield return pass.Trim();
                }
            }
        }

        // --- WINDOW CONTROLLERS ----------------------------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panelToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void panelToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboType.SelectedIndex)
            {
                case 0:
                    gbxIncremental.Visible = true;
                    gbxPresets.Visible = gbxCustom.Visible = false;
                    break;

                case 1:
                    gbxPresets.Visible = true;
                    gbxIncremental.Visible = gbxCustom.Visible = false;
                    break;

                case 2:
                    gbxCustom.Visible = true;
                    gbxIncremental.Visible = gbxPresets.Visible = false;
                    break;
            }
        }
        private void lblStats_Click(object sender, EventArgs e)
        {
            if (isAnimating)
                return;

            if (lblStats.Text == "► Open stats")
            {
                lblStats.Text = "▼ Close stats";
                targetHeight = 498;
            }
            else
            {
                lblStats.Text = "► Open stats";
                targetHeight = 411;
            }

            isAnimating = true;
            timerFormAnimation.Start();
        }
        private void timerFormAnimation_Tick(object sender, EventArgs e)
        {
            if (this.Height < targetHeight)
            {
                this.Height = Math.Min(this.Height + animationStep, targetHeight);
            }
            else if (this.Height > targetHeight)
            {
                this.Height = Math.Max(this.Height - animationStep, targetHeight);
            }

            if (this.Height == targetHeight)
            {
                timerFormAnimation.Stop();
                isAnimating = false;
            }
        }

        // --- COLOR GRADING ---------------------------------------------------------------------------------------------------------
        private void gbxSettings_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Lime, Color.Lime);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X, box.ClientRectangle.Y + (int)(strSize.Height / 2), box.ClientRectangle.Width - 1, box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                g.Clear(this.BackColor);

                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        private void btnAttack_MouseEnter(object sender, EventArgs e)
        {
            btnAttack.BackColor = Color.White;
        }
        private void btnAttack_MouseLeave(object sender, EventArgs e)
        {
            btnAttack.BackColor = Color.Lime;
        }
        private void btnUpload_MouseEnter(object sender, EventArgs e)
        {
            btnUpload.BackColor = Color.Lime;
            btnUpload.ForeColor = Color.Black;
        }
        private void btnCustom_MouseLeave(object sender, EventArgs e)
        {
            btnCustom.BackColor = Color.Black;
            btnCustom.ForeColor = Color.Lime;
        }
        private void btnCustom_MouseEnter(object sender, EventArgs e)
        {
            btnCustom.BackColor = Color.Lime;
            btnCustom.ForeColor = Color.Black;
        }
        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            btnUpload.BackColor = Color.Black;
            btnUpload.ForeColor = Color.Lime;
        }
    }
}