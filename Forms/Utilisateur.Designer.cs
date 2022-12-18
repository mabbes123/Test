namespace AOI
{
    partial class Utilisateur
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
            this.Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Login_err = new System.Windows.Forms.Label();
            this.First_Name_err = new System.Windows.Forms.Label();
            this.Last_Name_err = new System.Windows.Forms.Label();
            this.Type_err = new System.Windows.Forms.Label();
            this.Password_err = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CPassword_err = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.Location = new System.Drawing.Point(174, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(215, 23);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // First_Name
            // 
            this.First_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.First_Name.Location = new System.Drawing.Point(174, 52);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(215, 23);
            this.First_Name.TabIndex = 2;
            this.First_Name.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom";
            // 
            // Last_Name
            // 
            this.Last_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Last_Name.Location = new System.Drawing.Point(174, 93);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(215, 23);
            this.Last_Name.TabIndex = 5;
            this.Last_Name.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // Valider
            // 
            this.Valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Valider.Location = new System.Drawing.Point(163, 261);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(110, 24);
            this.Valider.TabIndex = 16;
            this.Valider.Text = "&Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler.Location = new System.Drawing.Point(279, 261);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(110, 24);
            this.Annuler.TabIndex = 17;
            this.Annuler.Text = "&Anuuler";
            this.Annuler.UseVisualStyleBackColor = true;
            // 
            // Login_err
            // 
            this.Login_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_err.AutoSize = true;
            this.Login_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_err.ForeColor = System.Drawing.Color.Red;
            this.Login_err.Location = new System.Drawing.Point(174, 36);
            this.Login_err.Name = "Login_err";
            this.Login_err.Size = new System.Drawing.Size(0, 13);
            this.Login_err.TabIndex = 18;
            // 
            // First_Name_err
            // 
            this.First_Name_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.First_Name_err.AutoSize = true;
            this.First_Name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.First_Name_err.ForeColor = System.Drawing.Color.Red;
            this.First_Name_err.Location = new System.Drawing.Point(174, 77);
            this.First_Name_err.Name = "First_Name_err";
            this.First_Name_err.Size = new System.Drawing.Size(0, 13);
            this.First_Name_err.TabIndex = 19;
            // 
            // Last_Name_err
            // 
            this.Last_Name_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Last_Name_err.AutoSize = true;
            this.Last_Name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Last_Name_err.ForeColor = System.Drawing.Color.Red;
            this.Last_Name_err.Location = new System.Drawing.Point(174, 118);
            this.Last_Name_err.Name = "Last_Name_err";
            this.Last_Name_err.Size = new System.Drawing.Size(0, 13);
            this.Last_Name_err.TabIndex = 20;
            // 
            // Type_err
            // 
            this.Type_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type_err.AutoSize = true;
            this.Type_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type_err.ForeColor = System.Drawing.Color.Red;
            this.Type_err.Location = new System.Drawing.Point(174, 159);
            this.Type_err.Name = "Type_err";
            this.Type_err.Size = new System.Drawing.Size(0, 13);
            this.Type_err.TabIndex = 21;
            // 
            // Password_err
            // 
            this.Password_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_err.AutoSize = true;
            this.Password_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_err.ForeColor = System.Drawing.Color.Red;
            this.Password_err.Location = new System.Drawing.Point(174, 200);
            this.Password_err.Name = "Password_err";
            this.Password_err.Size = new System.Drawing.Size(0, 13);
            this.Password_err.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mot de passe";
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(174, 175);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(215, 23);
            this.Password.TabIndex = 25;
            this.Password.TextChanged += new System.EventHandler(this.TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            // 
            // CPassword
            // 
            this.CPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPassword.Location = new System.Drawing.Point(174, 216);
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordChar = '●';
            this.CPassword.Size = new System.Drawing.Size(215, 23);
            this.CPassword.TabIndex = 28;
            this.CPassword.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Confirmation mot de passe";
            // 
            // CPassword_err
            // 
            this.CPassword_err.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPassword_err.AutoSize = true;
            this.CPassword_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPassword_err.ForeColor = System.Drawing.Color.Red;
            this.CPassword_err.Location = new System.Drawing.Point(174, 241);
            this.CPassword_err.Name = "CPassword_err";
            this.CPassword_err.Size = new System.Drawing.Size(0, 13);
            this.CPassword_err.TabIndex = 30;
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "1- Opérateur",
            "2- Administrateur"});
            this.Type.Location = new System.Drawing.Point(174, 134);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(215, 23);
            this.Type.TabIndex = 31;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 298);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.CPassword_err);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CPassword);
            this.Controls.Add(this.Password_err);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Type_err);
            this.Controls.Add(this.Last_Name_err);
            this.Controls.Add(this.First_Name_err);
            this.Controls.Add(this.Login_err);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter/Modifier Utilisateur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reference_FormClosing);
            this.Load += new System.EventHandler(this.Utilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Login;
        private Label label1;
        private TextBox First_Name;
        private Label label2;
        private Label label3;
        private TextBox Last_Name;
        private Label label4;
        private Button Valider;
        private Button Annuler;
        private Label Login_err;
        private Label First_Name_err;
        private Label Last_Name_err;
        private Label Type_err;
        private Label Password_err;
        private Label label8;
        private TextBox Password;
        private TextBox CPassword;
        private Label label10;
        private Label CPassword_err;
        private ComboBox Type;
    }
}