namespace AOI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY &&
                (int)m.WParam == WM_LBUTTONDOWN))
                if (!UserPanel.ClientRectangle.Contains(
                                 UserPanel.PointToClient(Cursor.Position)))
                    UserPanel.Hide();
            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gridInfo = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckProces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_Frigo_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckInterb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCreme = new System.Windows.Forms.CheckBox();
            this.Creme = new System.Windows.Forms.TextBox();
            this.UserManager = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.userName3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userName2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mode = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridInfo
            // 
            this.gridInfo.AllowDrop = true;
            this.gridInfo.AllowUserToAddRows = false;
            this.gridInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInfo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridInfo.ColumnHeadersHeight = 40;
            this.gridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.PartField,
            this.Barcode,
            this.Result,
            this.ProgramName,
            this.TesterName,
            this.RepairOperator,
            this.PanelID,
            this.PanelBarcode,
            this.PanelResult,
            this.EndDateTime,
            this.RefDes,
            this.LeadId,
            this.MachineCall,
            this.Side,
            this.LotNo,
            this.TypeAOI,
            this.CheckProces});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridInfo.EnableHeadersVisualStyles = false;
            this.gridInfo.GridColor = System.Drawing.Color.DarkGray;
            this.gridInfo.Location = new System.Drawing.Point(0, 288);
            this.gridInfo.MultiSelect = false;
            this.gridInfo.Name = "gridInfo";
            this.gridInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridInfo.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridInfo.RowTemplate.Height = 35;
            this.gridInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInfo.Size = new System.Drawing.Size(1439, 481);
            this.gridInfo.TabIndex = 14;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // PartField
            // 
            this.PartField.HeaderText = "RefCode";
            this.PartField.Name = "PartField";
            this.PartField.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 50;
            // 
            // ProgramName
            // 
            this.ProgramName.HeaderText = "Program Name";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            this.ProgramName.Width = 190;
            // 
            // TesterName
            // 
            this.TesterName.HeaderText = "TesterName";
            this.TesterName.Name = "TesterName";
            this.TesterName.ReadOnly = true;
            // 
            // RepairOperator
            // 
            this.RepairOperator.HeaderText = "Repair_Operator";
            this.RepairOperator.Name = "RepairOperator";
            this.RepairOperator.ReadOnly = true;
            // 
            // PanelID
            // 
            this.PanelID.HeaderText = "Panel_ID";
            this.PanelID.Name = "PanelID";
            this.PanelID.ReadOnly = true;
            // 
            // PanelBarcode
            // 
            this.PanelBarcode.HeaderText = "Panel_Barcode";
            this.PanelBarcode.Name = "PanelBarcode";
            this.PanelBarcode.ReadOnly = true;
            this.PanelBarcode.Width = 150;
            // 
            // PanelResult
            // 
            this.PanelResult.HeaderText = "Panel Result";
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.ReadOnly = true;
            // 
            // EndDateTime
            // 
            this.EndDateTime.HeaderText = "End Date Time";
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.ReadOnly = true;
            this.EndDateTime.Width = 150;
            // 
            // RefDes
            // 
            this.RefDes.HeaderText = "Ref Des";
            this.RefDes.Name = "RefDes";
            this.RefDes.ReadOnly = true;
            // 
            // LeadId
            // 
            this.LeadId.HeaderText = "Lead Id";
            this.LeadId.Name = "LeadId";
            this.LeadId.ReadOnly = true;
            // 
            // MachineCall
            // 
            this.MachineCall.HeaderText = "Machine_Call";
            this.MachineCall.Name = "MachineCall";
            this.MachineCall.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Width = 80;
            // 
            // LotNo
            // 
            this.LotNo.HeaderText = "Lot_No";
            this.LotNo.Name = "LotNo";
            this.LotNo.ReadOnly = true;
            // 
            // TypeAOI
            // 
            this.TypeAOI.HeaderText = "TypeAOI";
            this.TypeAOI.Name = "TypeAOI";
            this.TypeAOI.ReadOnly = true;
            // 
            // CheckProces
            // 
            this.CheckProces.HeaderText = "CheckProces";
            this.CheckProces.Name = "CheckProces";
            this.CheckProces.ReadOnly = true;
            // 
            // UID_2
            // 
            this.UID_2.HeaderText = "Cremes au CMS: 0";
            this.UID_2.Name = "UID_2";
            this.UID_2.Width = 150;
            // 
            // Out_Frigo_Date
            // 
            this.Out_Frigo_Date.HeaderText = "";
            this.Out_Frigo_Date.Name = "Out_Frigo_Date";
            this.Out_Frigo_Date.Width = 168;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(448, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(553, 62);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFilePath
            // 
            this.lbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lbFilePath.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFilePath.Location = new System.Drawing.Point(8, 184);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(1426, 62);
            this.lbFilePath.TabIndex = 15;
            this.lbFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SPI.Properties.Resources.Asteelflash_L;
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.FlatAppearance.BorderSize = 0;
            this.userName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Image = global::SPI.Properties.Resources.user;
            this.userName.Location = new System.Drawing.Point(1380, 7);
            this.userName.Margin = new System.Windows.Forms.Padding(0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(49, 49);
            this.userName.TabIndex = 10;
            this.userName.Text = "UN";
            this.userName.UseVisualStyleBackColor = false;
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(896, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1139, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.userName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1439, 65);
            this.panel2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CheckInterb);
            this.groupBox2.Location = new System.Drawing.Point(683, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interblockage";
            // 
            // CheckInterb
            // 
            this.CheckInterb.AutoSize = true;
            this.CheckInterb.Checked = true;
            this.CheckInterb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckInterb.Location = new System.Drawing.Point(6, 26);
            this.CheckInterb.Name = "CheckInterb";
            this.CheckInterb.Size = new System.Drawing.Size(134, 19);
            this.CheckInterb.TabIndex = 0;
            this.CheckInterb.Text = "Check Interblockage";
            this.CheckInterb.UseVisualStyleBackColor = true;
            this.CheckInterb.Click += new System.EventHandler(this.CheckInterb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkCreme);
            this.groupBox1.Controls.Add(this.Creme);
            this.groupBox1.Location = new System.Drawing.Point(277, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Creme";
            // 
            // checkCreme
            // 
            this.checkCreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkCreme.AutoSize = true;
            this.checkCreme.Checked = true;
            this.checkCreme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreme.Location = new System.Drawing.Point(267, 25);
            this.checkCreme.Name = "checkCreme";
            this.checkCreme.Size = new System.Drawing.Size(100, 19);
            this.checkCreme.TabIndex = 2;
            this.checkCreme.Text = "Check Créme ";
            this.checkCreme.UseVisualStyleBackColor = true;
            this.checkCreme.Click += new System.EventHandler(this.checkCreme_CheckedChanged);
            // 
            // Creme
            // 
            this.Creme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Creme.Location = new System.Drawing.Point(6, 23);
            this.Creme.Name = "Creme";
            this.Creme.Size = new System.Drawing.Size(228, 23);
            this.Creme.TabIndex = 0;
            // 
            // UserManager
            // 
            this.UserManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserManager.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserManager.FlatAppearance.BorderSize = 0;
            this.UserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserManager.Location = new System.Drawing.Point(-2, 83);
            this.UserManager.Name = "UserManager";
            this.UserManager.Size = new System.Drawing.Size(271, 40);
            this.UserManager.TabIndex = 11;
            this.UserManager.Text = "Gestion des utilisateurs";
            this.UserManager.UseVisualStyleBackColor = false;
            this.UserManager.Click += new System.EventHandler(this.UserManager_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(157)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(-2, 124);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(271, 40);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Déconnecter";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // userName3
            // 
            this.userName3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName3.Location = new System.Drawing.Point(82, 0);
            this.userName3.Name = "userName3";
            this.userName3.Size = new System.Drawing.Size(187, 50);
            this.userName3.TabIndex = 9;
            this.userName3.Text = "User Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.userName2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 10;
            // 
            // userName2
            // 
            this.userName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(157)))));
            this.userName2.FlatAppearance.BorderSize = 0;
            this.userName2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName2.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName2.Location = new System.Drawing.Point(7, 7);
            this.userName2.Name = "userName2";
            this.userName2.Size = new System.Drawing.Size(66, 66);
            this.userName2.TabIndex = 9;
            this.userName2.Text = "UN";
            this.userName2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 1);
            this.panel1.TabIndex = 9;
            // 
            // mode
            // 
            this.mode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mode.Location = new System.Drawing.Point(84, 61);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(181, 14);
            this.mode.TabIndex = 9;
            this.mode.Text = "Mode: N/A";
            this.mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(80, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 1);
            this.panel4.TabIndex = 10;
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPanel.Controls.Add(this.panel4);
            this.UserPanel.Controls.Add(this.mode);
            this.UserPanel.Controls.Add(this.panel1);
            this.UserPanel.Controls.Add(this.panel3);
            this.UserPanel.Controls.Add(this.userName3);
            this.UserPanel.Controls.Add(this.Logout);
            this.UserPanel.Controls.Add(this.UserManager);
            this.UserPanel.Location = new System.Drawing.Point(1140, 32);
            this.UserPanel.MaximumSize = new System.Drawing.Size(270, 166);
            this.UserPanel.MinimumSize = new System.Drawing.Size(270, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(270, 166);
            this.UserPanel.TabIndex = 8;
            this.UserPanel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 770);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridInfo);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1455, 809);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPI_KOH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn UID_2;
        private DataGridViewTextBoxColumn Out_Frigo_Date;
        private System.Windows.Forms.Timer timer1;
        public DataGridView gridInfo;
        private System.Windows.Forms.Timer timer2;
        public Label lblStatus;
        public Label lbFilePath;
        private PictureBox pictureBox1;
        private Button userName;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Button UserManager;
        private Button Logout;
        private Label userName3;
        private Panel panel3;
        private Button userName2;
        private Panel panel1;
        private Label mode;
        private Panel panel4;
        private Panel UserPanel;
        private GroupBox groupBox2;
        private CheckBox CheckInterb;
        private GroupBox groupBox1;
        private TextBox Creme;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn PartField;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn ProgramName;
        private DataGridViewTextBoxColumn TesterName;
        private DataGridViewTextBoxColumn RepairOperator;
        private DataGridViewTextBoxColumn PanelID;
        private DataGridViewTextBoxColumn PanelBarcode;
        private DataGridViewTextBoxColumn PanelResult;
        private DataGridViewTextBoxColumn EndDateTime;
        private DataGridViewTextBoxColumn RefDes;
        private DataGridViewTextBoxColumn LeadId;
        private DataGridViewTextBoxColumn MachineCall;
        private DataGridViewTextBoxColumn Side;
        private DataGridViewTextBoxColumn LotNo;
        private DataGridViewTextBoxColumn TypeAOI;
        private DataGridViewTextBoxColumn CheckProces;
        private CheckBox checkCreme;
    }
}