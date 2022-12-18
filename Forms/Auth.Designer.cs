namespace SPI.Forms
{
    partial class Auth
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.ComboBox();
            this.password_err = new System.Windows.Forms.Label();
            this.login_err = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Label();
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
            this.BTN_OK.Location = new System.Drawing.Point(53, 248);
            this.BTN_OK.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(698, 32);
            this.BTN_OK.TabIndex = 33;
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
            this.BTN_Annuler.Location = new System.Drawing.Point(53, 287);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(698, 32);
            this.BTN_Annuler.TabIndex = 34;
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
            this.login.Location = new System.Drawing.Point(53, 74);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(698, 33);
            this.login.TabIndex = 31;
            // 
            // password_err
            // 
            this.password_err.AutoSize = true;
            this.password_err.BackColor = System.Drawing.Color.Transparent;
            this.password_err.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.password_err.Location = new System.Drawing.Point(53, 200);
            this.password_err.Name = "password_err";
            this.password_err.Size = new System.Drawing.Size(0, 13);
            this.password_err.TabIndex = 38;
            // 
            // login_err
            // 
            this.login_err.AutoSize = true;
            this.login_err.BackColor = System.Drawing.Color.Transparent;
            this.login_err.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.login_err.Location = new System.Drawing.Point(53, 113);
            this.login_err.Name = "login_err";
            this.login_err.Size = new System.Drawing.Size(0, 13);
            this.login_err.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mot de passe";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(53, 161);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(698, 33);
            this.password.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Login";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.Azure;
            this.clear.Location = new System.Drawing.Point(656, 113);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 15);
            this.clear.TabIndex = 39;
            this.clear.Text = "Effacer les logins";
            // 
            // Auth
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(800, 372);
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
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
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
    }
}