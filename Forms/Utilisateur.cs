using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOI
{
    public partial class Utilisateur : Form
    {
        public Utilisateur()
        {
            InitializeComponent();
            this.Text = "Ajouter Utilisateur";
            this.Login.Text = "";
            this.First_Name.Text = "";
            this.Last_Name.Text = "";
            this.Type.SelectedItem = this.Type.Items[0];
            this.Password.Text = "";
            this.CPassword.Text = "";
            this.Login.Enabled = true;
            this.CPassword.Enabled = true;
        }
        public Utilisateur(string Login, string First_Name, string Last_Name, string Type)
        {
            InitializeComponent();
            this.Text = "Modifier Utilisateur";
            this.Login.Text = Login;
            this.First_Name.Text = First_Name;
            this.Last_Name.Text = Last_Name;
            this.Type.SelectedItem = Type == "op" ? this.Type.Items[0] :
                    this.Type.SelectedItem = Type == "ad" ? this.Type.Items[1] : null;
            this.Password.Text = "ThisIsAFakePassword";
            this.CPassword.Text = "";
            this.Login.Enabled = false;
            this.CPassword.Enabled = false;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Login_err.Text = this.Login.Text == "" ? "Login ne peut pas être vide." : "";
            First_Name_err.Text = this.First_Name.Text == "" ? "Nom ne peut pas être vide." : "";
            Last_Name_err.Text = this.Last_Name.Text == "" ? "Prénom ne peut pas être vide." : "";
            Type_err.Text = this.Type.Text == "" ? "Type ne peut pas être vide." : "";
            Password_err.Text = this.Password.Text == "" ? "Mot de passe ne peut pas être vide." : "";
            if (CPassword.Enabled && this.CPassword.Text != Password.Text)
            {
                this.CPassword_err.Text = "Mot de passe n'est pas identique.";
                this.CPassword.Text = "";
            }
            else
            {
                this.CPassword_err.Text = "";
            }
            if (Login_err.Text.Length > 0 || First_Name_err.Text.Length > 0 || Last_Name_err.Text.Length > 0
                || Type_err.Text.Length > 0 || Password_err.Text.Length > 0 || CPassword_err.Text.Length > 0) return;


            if (this.Login.Enabled == true) // Ajouter
            {
                if (Operator.getByLogin(Login.Text) != null)
                {
                    Login_err.Text = "Login déjà utilisé";
                    return;
                }
                else
                {
                    Operator user = new Operator(0, First_Name.Text, Last_Name.Text, Login.Text, Password.Text, "", DateTime.Now);
                    user.Type = Type.SelectedIndex == 0 ? "op" : user.Type = Type.SelectedIndex == 1 ? "cq" : user.Type = Type.SelectedIndex == 2 ? "ad" : "";
                    Operator.Create(user);
                }
            }
            else // Modifier
            {
                Operator user = Operator.getByLogin(Login.Text);
                user.First_Name = First_Name.Text;
                user.Last_Name = Last_Name.Text;
                user.Type = Type.SelectedIndex == 0 ? "op" : user.Type = Type.SelectedIndex == 1 ? "cq" : user.Type = Type.SelectedIndex == 2 ? "ad" : "";
                if(CPassword.Enabled) user.Password = Password.Text;
                Operator.Update(user);
            }
        }
        private void Reference_FormClosing(object sender, FormClosingEventArgs e)
        {

            if ((Login_err.Text.Length > 0 || First_Name_err.Text.Length > 0 || Last_Name_err.Text.Length > 0
                || Type_err.Text.Length > 0 || Password_err.Text.Length > 0 || CPassword_err.Text.Length > 0) && this.DialogResult == DialogResult.OK) e.Cancel = true;
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            CPassword.Enabled = true;
            if (this.Password.Text == "ThisIsAFakePassword")
                this.Password.Text = "";
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if (field.Name == "Login") Login_err.Text = "";
            if (field.Name == "First_Name") First_Name_err.Text = "";
            if (field.Name == "Last_Name") Last_Name_err.Text = "";
            if (field.Name == "Password") Password_err.Text = "";
            if (field.Name == "CPassword") CPassword_err.Text = "";
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
