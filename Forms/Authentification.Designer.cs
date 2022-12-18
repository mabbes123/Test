namespace AOI
{
    partial class Authentification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.ComboBox();
            this.password_err = new System.Windows.Forms.Label();
            this.login_err = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.BTN_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.BTN_OK.FlatAppearance.BorderSize = 0;
            this.BTN_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_OK.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_OK.Location = new System.Drawing.Point(49, 526);
            this.BTN_OK.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(698, 32);
            this.BTN_OK.TabIndex = 24;
            this.BTN_OK.Text = "&Connecter";
            this.BTN_OK.UseVisualStyleBackColor = false;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Annuler.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BTN_Annuler.FlatAppearance.BorderSize = 0;
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Annuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Annuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Annuler.Location = new System.Drawing.Point(49, 565);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(698, 32);
            this.BTN_Annuler.TabIndex = 25;
            this.BTN_Annuler.TabStop = false;
            this.BTN_Annuler.Text = "&Quitter";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // login
            // 
            this.login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.Navy;
            this.login.FormattingEnabled = true;
            this.login.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.login.Location = new System.Drawing.Point(49, 352);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(698, 33);
            this.login.TabIndex = 22;
            // 
            // password_err
            // 
            this.password_err.AutoSize = true;
            this.password_err.BackColor = System.Drawing.Color.Transparent;
            this.password_err.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.password_err.Location = new System.Drawing.Point(49, 478);
            this.password_err.Name = "password_err";
            this.password_err.Size = new System.Drawing.Size(0, 13);
            this.password_err.TabIndex = 29;
            // 
            // login_err
            // 
            this.login_err.AutoSize = true;
            this.login_err.BackColor = System.Drawing.Color.Transparent;
            this.login_err.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.login_err.Location = new System.Drawing.Point(49, 391);
            this.login_err.Name = "login_err";
            this.login_err.Size = new System.Drawing.Size(0, 13);
            this.login_err.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(49, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mot de passe";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(49, 439);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(698, 33);
            this.password.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Login";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.Azure;
            this.clear.Location = new System.Drawing.Point(652, 391);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 15);
            this.clear.TabIndex = 30;
            this.clear.Text = "Effacer les logins";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.version.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.version.ForeColor = System.Drawing.SystemColors.Control;
            this.version.Location = new System.Drawing.Point(463, 128);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(202, 30);
            this.version.TabIndex = 36;
            this.version.Text = "@Version";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(682, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "© Copyright 2022";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(0, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(794, 51);
            this.label5.TabIndex = 33;
            this.label5.Text = "Solder Paste Inspection (SPI)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPI.Properties.Resources.Loading;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Asteelflash (SKR-04-IT)";
            // 
            // Authentification
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 642);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_err);
            this.Controls.Add(this.login_err);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authentification";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authentification_FormClosed);
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_OK;
        private Button BTN_Annuler;
        private ComboBox login;
        private Label password_err;
        private Label login_err;
        private Label label2;
        private TextBox password;
        private Label label1;
        private Label clear;
        private Label version;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
    }
}