namespace AOI
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        public Authentification(string login)
        {
            InitializeComponent();
            this.login.Text = login;
            this.password.Focus();
        }
        private void Authentification_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            this.version.Text = "v" + version.ToString();
            if (!File.Exists("Config.txt")) File.Create("Config.txt");
            Config.readLogins("Config.txt");
            foreach (string line in Config.logins)
            {
                this.login.Items.Add(line);
                this.login.AutoCompleteCustomSource.Add(line);
            }
        }
        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            login_err.Text = "";
        }
        private void login_SelectedIndexChanged(object sender, EventArgs e)
        {
            login_err.Text = "";
        }
        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            password_err.Text = "";
        }
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.login_err.Text = "";
            this.password_err.Text = "";
            this.login.Text = "";
            this.password.Text = "";
            this.login.Focus();
            Application.ExitThread();
        }
        private Point MouseDownLocation;



        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }



        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            login_err.Text = login.Text=="" ? "Entrer votre login svp." : "";
            password_err.Text = password.Text == "" ? "Entrer votre mot de passe svp." : "";
            if (login_err.Text!="" || password_err.Text!= "")
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

            Operator.current = Operator.getByLoginPassword(login.Text, password.Text);
            if (Operator.current is null)
            {
                password.Text = "";
                password_err.Text = "Mot de passe est incorrect.";
                this.password.Focus();
                return;
            }
           
            if(login.Items.Contains(login.Text)==false)
            {
                this.login.Items.Add(login.Text);
                this.login.AutoCompleteCustomSource.Add(login.Text);
                Config.logins.Add(login.Text);
                Config.writeLogins("Config.txt");
            }
            password.Text = "";
            new Main().Show();
            this.Hide();
         }
        private void clear_Click(object sender, EventArgs e)
        {
            Config.logins.Clear();
            this.login.Items.Clear();
            this.login.AutoCompleteCustomSource.Clear();
            Config.writeLogins("Config.txt");
        }
    }
}