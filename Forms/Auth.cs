using AOI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPI.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;   
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            login_err.Text = login.Text == "" ? "Entrer votre login svp." : "";
            password_err.Text = password.Text == "" ? "Entrer votre mot de passe svp." : "";
            if (login_err.Text != "" || password_err.Text != "")
                return;

            Operator.current = Operator.getByLogin(login.Text);
            {
                if (Operator.current is null)
                {
                    login.Text = "";
                    password.Text = "";
                    login_err.Text = "Compte inexistant. Vérifier votre login";
                    this.login.Focus();
                    return;
                }
            }           
            Operator op = Operator.getByLoginPassword(login.Text, password.Text);
            if (op is null)
            {
                password.Text = "";
                password_err.Text = "Mot de passe est incorrect.";
                this.password.Focus();
                return;
            }
            if (login.Items.Contains(login.Text) == false)
            {
                this.login.Items.Add(login.Text);
                this.login.AutoCompleteCustomSource.Add(login.Text);
                Config.logins.Add(login.Text);
                Config.writeLogins("Config.txt");
            }
            password.Text = "";
            if(op.Type == "ad")
            {
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                password.Text = "";
                login_err.Text = "Vous devez connecter en tantque administrateur";
                this.password.Focus();
                return;
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Config.txt")) File.Create("Config.txt");
            Config.readLogins("Config.txt");
            foreach (string line in Config.logins)
            {
                this.login.Items.Add(line);
                this.login.AutoCompleteCustomSource.Add(line);
            }
        }
    }
}
