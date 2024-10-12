namespace Brute_Force_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.chkRam = new System.Windows.Forms.CheckBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxCustom = new System.Windows.Forms.GroupBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.gbxPresets = new System.Windows.Forms.GroupBox();
            this.rbt1900 = new System.Windows.Forms.RadioButton();
            this.rbt10mplt = new System.Windows.Forms.RadioButton();
            this.rbtRockyou = new System.Windows.Forms.RadioButton();
            this.gbxIncremental = new System.Windows.Forms.GroupBox();
            this.chkAccents = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblCurPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.timerStats = new System.Windows.Forms.Timer(this.components);
            this.lblStats = new System.Windows.Forms.Label();
            this.timerFormAnimation = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxOpen = new System.Windows.Forms.PictureBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gbxSettings.SuspendLayout();
            this.gbxCustom.SuspendLayout();
            this.gbxPresets.SuspendLayout();
            this.gbxIncremental.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpen)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.Black;
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZip.Enabled = false;
            this.txtZip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.ForeColor = System.Drawing.Color.White;
            this.txtZip.Location = new System.Drawing.Point(19, 238);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4);
            this.txtZip.MaxLength = 256;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(200, 23);
            this.txtZip.TabIndex = 1;
            this.txtZip.Text = "C:\\Users\\USERNAME\\Desktop";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Lime;
            this.panelToolbar.Controls.Add(this.label2);
            this.panelToolbar.Controls.Add(this.btnClose);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(4);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(930, 30);
            this.panelToolbar.TabIndex = 5;
            this.panelToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            this.panelToolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseMove);
            this.panelToolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zip Cracker 2.8";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Brute_Force_2.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(904, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxSettings
            // 
            this.gbxSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbxSettings.Controls.Add(this.chkRam);
            this.gbxSettings.Controls.Add(this.btnUpload);
            this.gbxSettings.Controls.Add(this.label4);
            this.gbxSettings.Controls.Add(this.gbxCustom);
            this.gbxSettings.Controls.Add(this.gbxPresets);
            this.gbxSettings.Controls.Add(this.gbxIncremental);
            this.gbxSettings.Controls.Add(this.cboType);
            this.gbxSettings.Controls.Add(this.label3);
            this.gbxSettings.Controls.Add(this.txtZip);
            this.gbxSettings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSettings.ForeColor = System.Drawing.Color.Lime;
            this.gbxSettings.Location = new System.Drawing.Point(12, 34);
            this.gbxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSettings.Size = new System.Drawing.Size(905, 299);
            this.gbxSettings.TabIndex = 6;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Brute-force settings";
            this.gbxSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.gbxSettings_Paint);
            // 
            // chkRam
            // 
            this.chkRam.AutoSize = true;
            this.chkRam.Checked = true;
            this.chkRam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRam.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRam.Location = new System.Drawing.Point(19, 269);
            this.chkRam.Name = "chkRam";
            this.chkRam.Size = new System.Drawing.Size(159, 19);
            this.chkRam.TabIndex = 19;
            this.chkRam.Text = "Stabilize RAM usage";
            this.chkRam.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Black;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Lime;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(228, 238);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(71, 23);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            this.btnUpload.MouseEnter += new System.EventHandler(this.btnUpload_MouseEnter);
            this.btnUpload.MouseLeave += new System.EventHandler(this.btnUpload_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Protected file:";
            // 
            // gbxCustom
            // 
            this.gbxCustom.BackColor = System.Drawing.Color.Transparent;
            this.gbxCustom.Controls.Add(this.btnCustom);
            this.gbxCustom.Controls.Add(this.label1);
            this.gbxCustom.Controls.Add(this.txtCustom);
            this.gbxCustom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustom.ForeColor = System.Drawing.Color.Lime;
            this.gbxCustom.Location = new System.Drawing.Point(617, 55);
            this.gbxCustom.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCustom.Name = "gbxCustom";
            this.gbxCustom.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCustom.Size = new System.Drawing.Size(280, 152);
            this.gbxCustom.TabIndex = 16;
            this.gbxCustom.TabStop = false;
            this.gbxCustom.Text = "Custom database";
            this.gbxCustom.Visible = false;
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.Black;
            this.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.Lime;
            this.btnCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustom.Location = new System.Drawing.Point(19, 71);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(242, 23);
            this.btnCustom.TabIndex = 21;
            this.btnCustom.Text = "Upload file";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            this.btnCustom.MouseEnter += new System.EventHandler(this.btnCustom_MouseEnter);
            this.btnCustom.MouseLeave += new System.EventHandler(this.btnCustom_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path:";
            // 
            // txtCustom
            // 
            this.txtCustom.BackColor = System.Drawing.Color.Black;
            this.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustom.ForeColor = System.Drawing.Color.White;
            this.txtCustom.Location = new System.Drawing.Point(19, 44);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustom.MaxLength = 256;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(242, 23);
            this.txtCustom.TabIndex = 20;
            this.txtCustom.Text = "C:\\Users\\USERNAME\\Desktop";
            // 
            // gbxPresets
            // 
            this.gbxPresets.BackColor = System.Drawing.Color.Transparent;
            this.gbxPresets.Controls.Add(this.rbt1900);
            this.gbxPresets.Controls.Add(this.rbt10mplt);
            this.gbxPresets.Controls.Add(this.rbtRockyou);
            this.gbxPresets.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPresets.ForeColor = System.Drawing.Color.Lime;
            this.gbxPresets.Location = new System.Drawing.Point(329, 55);
            this.gbxPresets.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPresets.Name = "gbxPresets";
            this.gbxPresets.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPresets.Size = new System.Drawing.Size(280, 152);
            this.gbxPresets.TabIndex = 16;
            this.gbxPresets.TabStop = false;
            this.gbxPresets.Text = "Databases";
            this.gbxPresets.Visible = false;
            // 
            // rbt1900
            // 
            this.rbt1900.AutoSize = true;
            this.rbt1900.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1900.Location = new System.Drawing.Point(16, 73);
            this.rbt1900.Name = "rbt1900";
            this.rbt1900.Size = new System.Drawing.Size(116, 19);
            this.rbt1900.TabIndex = 12;
            this.rbt1900.TabStop = true;
            this.rbt1900.Text = "1900-2030.txt";
            this.rbt1900.UseVisualStyleBackColor = true;
            // 
            // rbt10mplt
            // 
            this.rbt10mplt.AutoSize = true;
            this.rbt10mplt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt10mplt.Location = new System.Drawing.Point(16, 48);
            this.rbt10mplt.Name = "rbt10mplt";
            this.rbt10mplt.Size = new System.Drawing.Size(95, 19);
            this.rbt10mplt.TabIndex = 11;
            this.rbt10mplt.TabStop = true;
            this.rbt10mplt.Text = "10mplt.txt";
            this.rbt10mplt.UseVisualStyleBackColor = true;
            // 
            // rbtRockyou
            // 
            this.rbtRockyou.AutoSize = true;
            this.rbtRockyou.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRockyou.Location = new System.Drawing.Point(16, 23);
            this.rbtRockyou.Name = "rbtRockyou";
            this.rbtRockyou.Size = new System.Drawing.Size(102, 19);
            this.rbtRockyou.TabIndex = 10;
            this.rbtRockyou.TabStop = true;
            this.rbtRockyou.Text = "rockyou.txt";
            this.rbtRockyou.UseVisualStyleBackColor = true;
            // 
            // gbxIncremental
            // 
            this.gbxIncremental.BackColor = System.Drawing.Color.Transparent;
            this.gbxIncremental.Controls.Add(this.chkAccents);
            this.gbxIncremental.Controls.Add(this.chkDigits);
            this.gbxIncremental.Controls.Add(this.chkSpecial);
            this.gbxIncremental.Controls.Add(this.chkUpper);
            this.gbxIncremental.Controls.Add(this.chkLower);
            this.gbxIncremental.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxIncremental.ForeColor = System.Drawing.Color.Lime;
            this.gbxIncremental.Location = new System.Drawing.Point(19, 55);
            this.gbxIncremental.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIncremental.Name = "gbxIncremental";
            this.gbxIncremental.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIncremental.Size = new System.Drawing.Size(280, 152);
            this.gbxIncremental.TabIndex = 15;
            this.gbxIncremental.TabStop = false;
            this.gbxIncremental.Text = "Filters";
            // 
            // chkAccents
            // 
            this.chkAccents.AutoSize = true;
            this.chkAccents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccents.Location = new System.Drawing.Point(16, 123);
            this.chkAccents.Name = "chkAccents";
            this.chkAccents.Size = new System.Drawing.Size(75, 19);
            this.chkAccents.TabIndex = 9;
            this.chkAccents.Text = "Accents";
            this.chkAccents.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDigits.Location = new System.Drawing.Point(16, 73);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(68, 19);
            this.chkDigits.TabIndex = 8;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecial.Location = new System.Drawing.Point(16, 98);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(152, 19);
            this.chkSpecial.TabIndex = 7;
            this.chkSpecial.Text = "Special characters";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpper.Location = new System.Drawing.Point(16, 48);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(166, 19);
            this.chkUpper.TabIndex = 6;
            this.chkUpper.Text = "Uppercase characters";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLower.Location = new System.Drawing.Point(16, 23);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(166, 19);
            this.chkLower.TabIndex = 5;
            this.chkLower.Text = "Lowercase characters";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.Black;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.ForeColor = System.Drawing.Color.Lime;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Incremental",
            "Default wordlists",
            "Custom files"});
            this.cboType.Location = new System.Drawing.Point(75, 27);
            this.cboType.MaxDropDownItems = 3;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(224, 22);
            this.cboType.TabIndex = 14;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 468);
            this.panel3.TabIndex = 10;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Lime;
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttack.Location = new System.Drawing.Point(241, 362);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(92, 37);
            this.btnAttack.TabIndex = 19;
            this.btnAttack.Text = "ATTACK";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click_1);
            this.btnAttack.MouseEnter += new System.EventHandler(this.btnAttack_MouseEnter);
            this.btnAttack.MouseLeave += new System.EventHandler(this.btnAttack_MouseLeave);
            // 
            // lblCurPassword
            // 
            this.lblCurPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurPassword.ForeColor = System.Drawing.Color.Lime;
            this.lblCurPassword.Location = new System.Drawing.Point(12, 362);
            this.lblCurPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurPassword.Name = "lblCurPassword";
            this.lblCurPassword.Size = new System.Drawing.Size(219, 37);
            this.lblCurPassword.TabIndex = 20;
            this.lblCurPassword.Text = "AAAAAAAAAAAAAAA";
            this.lblCurPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(8, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total attepms:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(110, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 15);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "99999 x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Lime;
            this.lblSpeed.Location = new System.Drawing.Point(54, 34);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(133, 15);
            this.lblSpeed.TabIndex = 24;
            this.lblSpeed.Text = "9999 passwords/sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Time elapsed:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(103, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(91, 15);
            this.lblTimer.TabIndex = 22;
            this.lblTimer.Text = "00:00:00.000";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(2, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 2);
            this.panel4.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(8, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Current password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerStats
            // 
            this.timerStats.Enabled = true;
            this.timerStats.Interval = 10;
            this.timerStats.Tick += new System.EventHandler(this.timerStats_Tick);
            // 
            // lblStats
            // 
            this.lblStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStats.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.Honeydew;
            this.lblStats.Location = new System.Drawing.Point(239, 342);
            this.lblStats.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(98, 15);
            this.lblStats.TabIndex = 30;
            this.lblStats.Text = "► Open stats";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStats.Visible = false;
            this.lblStats.Click += new System.EventHandler(this.lblStats_Click);
            // 
            // timerFormAnimation
            // 
            this.timerFormAnimation.Interval = 10;
            this.timerFormAnimation.Tick += new System.EventHandler(this.timerFormAnimation_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lime;
            this.panel5.Location = new System.Drawing.Point(925, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 438);
            this.panel5.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(928, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 468);
            this.panel1.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Lime;
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 468);
            this.panel6.TabIndex = 31;
            // 
            // pbxClose
            // 
            this.pbxClose.Image = global::Brute_Force_2.Properties.Resources.padlockClose;
            this.pbxClose.Location = new System.Drawing.Point(271, 12);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(60, 60);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 32;
            this.pbxClose.TabStop = false;
            // 
            // pbxOpen
            // 
            this.pbxOpen.Image = global::Brute_Force_2.Properties.Resources.padlockOpen;
            this.pbxOpen.Location = new System.Drawing.Point(271, 12);
            this.pbxOpen.Name = "pbxOpen";
            this.pbxOpen.Size = new System.Drawing.Size(60, 60);
            this.pbxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOpen.TabIndex = 33;
            this.pbxOpen.TabStop = false;
            this.pbxOpen.Visible = false;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.pbxClose);
            this.panelStats.Controls.Add(this.label7);
            this.panelStats.Controls.Add(this.pbxOpen);
            this.panelStats.Controls.Add(this.lblTimer);
            this.panelStats.Controls.Add(this.lblSpeed);
            this.panelStats.Controls.Add(this.label6);
            this.panelStats.Controls.Add(this.label5);
            this.panelStats.Controls.Add(this.lblTotal);
            this.panelStats.Location = new System.Drawing.Point(2, 411);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(344, 85);
            this.panelStats.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 2);
            this.panel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 498);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurPassword);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelStats);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zip Cracker 2.8";
            this.TopMost = true;
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxCustom.ResumeLayout(false);
            this.gbxCustom.PerformLayout();
            this.gbxPresets.ResumeLayout(false);
            this.gbxPresets.PerformLayout();
            this.gbxIncremental.ResumeLayout(false);
            this.gbxIncremental.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpen)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.RadioButton rbtRockyou;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxCustom;
        private System.Windows.Forms.GroupBox gbxPresets;
        private System.Windows.Forms.GroupBox gbxIncremental;
        private System.Windows.Forms.CheckBox chkAccents;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblCurPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer timerFormAnimation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxOpen;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.CheckBox chkRam;
        private System.Windows.Forms.RadioButton rbt1900;
        private System.Windows.Forms.RadioButton rbt10mplt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label label1;
    }
}

