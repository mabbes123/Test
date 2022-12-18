using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_Creme_a_Braser__GCB_
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string sql = "SELECT First_Name Nom, Last_Name Prénom, Login, type FROM Operator";
            SQLServer.cnx.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, SQLServer.cnx);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Operator");
            SQLServer.cnx.Close();
            //for(int i = ds.Tables[0].Rows.Count; i<14; i++) ds.Tables[0].Rows.Add();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Operator";
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 210;
            dataGridView1.Columns[3].Width = 130;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString() != "")
                {
                    row.ContextMenuStrip = Menu;
                    row.Cells[3].Value = row.Cells[3].Value.ToString() == "ad" ? "Administrateur" :
                        row.Cells[3].Value.ToString() == "op" ? "Opérateur" :
                        row.Cells[3].Value.ToString() == "cq" ? "Contrôle qualité" : "N/A";
                }
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) row.Selected = false;
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                supprimerToolStripMenuItem.Enabled =
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == Utilisateur.current.getLogin() ? false : true;
            }

        }
        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text == "ThisNotYourRearPassword") password.Text = "";
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            confirmpassword.Enabled = true;
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() != "")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Utilisateur.deleteByLogin(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    this.Users_Load(sender, e);
                }
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
                row.ContextMenuStrip = Menu;
            }

        }

        private void type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            login.Text = "";
            firstname.Text = "";
            lastname.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
            type.Text = type.Items[0].ToString();
            login_err.Text = "";
            firstname_err.Text = "";
            lastname_err.Text = "";
            password_err.Text = "";
            confirmpassword_err.Text = "";
            Validate.Text = "Ajouter / Modifier";
            login.Enabled = true;
            addEdit.Enabled = false;
            dataGridView1.Enabled = true;
            dataGridView1.Focus();
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            login.Text = "";
            firstname.Text = "";
            lastname.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
            type.Text = type.Items[0].ToString();
            login_err.Text = "";
            firstname_err.Text = "";
            lastname_err.Text = "";
            password_err.Text = "";
            confirmpassword_err.Text = "";
            Validate.Text = "&Ajouter";
            confirmpassword.Enabled = true;
            login.Enabled = true;
            addEdit.Enabled = true;
            dataGridView1.Enabled = false;
            login.Focus();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Utilisateur user = Utilisateur.getByLogin(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                login.Text = user.getLogin();
                firstname.Text = user.getFirst_Name();
                lastname.Text = user.getLast_Name();
                password.Text = "ThisNotYourRearPassword";
                confirmpassword.Text = "";
                type.Text = user.getType() == "ad" ? "1 - Administrateur" :
                     user.getType() == "cq" ? "2 - Contrôle Qualité" :
                     user.getType() == "op" ? "3 - Opérateur" : "";
                login_err.Text = "";
                firstname_err.Text = "";
                lastname_err.Text = "";
                password_err.Text = "";
                confirmpassword_err.Text = "";
                Validate.Text = "&Modifier";
                confirmpassword.Enabled = false;
                login.Enabled = false;
                addEdit.Enabled = true;
                dataGridView1.Enabled = false;
                firstname.Focus();
            }
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {
            this.Users_Load(sender, e);
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (login.Text == "") login_err.Text = "Veuillez remplir ce champs"; else login_err.Text = "";
            if (firstname.Text == "") firstname_err.Text = "Veuillez remplir ce champs"; else firstname_err.Text = "";
            if (lastname.Text == "") lastname_err.Text = "Veuillez remplir ce champs"; else lastname_err.Text = "";
            if (password.Text == "") password_err.Text = "Veuillez remplir ce champs"; else password_err.Text = "";
            if (login.Text == "" || firstname.Text == "" || lastname.Text == "" || password.Text == "")
                return;
            confirmpassword_err.Text = "";
            Button buttonClicked = (Button)sender;
            if (buttonClicked.Text == "&Ajouter")
            {
                if (password.Text != confirmpassword.Text)
                {
                    confirmpassword_err.Text = "N'est pas conform au mot de passe";
                    confirmpassword.Text = "";
                    confirmpassword.Focus();
                    return;
                }
                Utilisateur user = Utilisateur.getByLogin(login.Text);
                if (user != null)
                {
                    login_err.Text = "Cet utilisateur déjà existe.";
                    return;
                }
                user = new Utilisateur(0, login.Text, password.Text, firstname.Text, lastname.Text,
                    type.SelectedIndex == 0 ? "ad" : type.SelectedIndex == 1 ? "cq" : type.SelectedIndex == 2 ? "op" : "");
                if (Utilisateur.Create(user))
                    MessageBox.Show("Utilisateur est ajouté avec succées.", "Succées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Un erreur se produit lors d'ajout.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Users_Load(sender, e);
                cancel.PerformClick();
            }
            else
            {
                if (confirmpassword.Enabled == true && password.Text != confirmpassword.Text)
                {
                    confirmpassword_err.Text = "N'est pas conform au mot de passe";
                    confirmpassword.Text = "";
                    confirmpassword.Focus();
                    return;
                }
                Utilisateur user = Utilisateur.getByLogin(login.Text);
                user = new Utilisateur(0, login.Text, confirmpassword.Text==""?user.getPassword():password.Text, firstname.Text, lastname.Text,
                    type.SelectedIndex == 0 ? "ad" : type.SelectedIndex == 1 ? "cq" : type.SelectedIndex == 2 ? "op" : "");
                if (Utilisateur.Update(user))
                    MessageBox.Show("Utilisateur est modifié avec succées.", "Succées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Un erreur se produit lors de la modification.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Users_Load(sender, e);
                cancel.PerformClick();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (e.KeyData == Keys.Delete)
                    supprimerToolStripMenuItem.PerformClick();
                if (e.KeyData == Keys.F2)
                    modifierToolStripMenuItem.PerformClick();
                if (e.KeyData == Keys.F5)
                    actualiserToolStripMenuItem.PerformClick();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 14)
                ajouterToolStripMenuItem.PerformClick();
            if (e.KeyChar == 6)
                rechercherToolStripMenuItem.PerformClick();     
        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Veuillez entrer la valeur à rechercher", "Recherche");
            string sql = "SELECT First_Name Nom, Last_Name Prénom, Login, type FROM Operator " +
                "WHERE First_Name like '%"+ promptValue + "%' OR " +
                "Last_Name like '%" + promptValue + "%' OR " +
                "Login like '%" + promptValue + "%' OR " +
                "type like '%" + promptValue + "%'";

            SQLServer.cnx.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, SQLServer.cnx);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Operator");
            SQLServer.cnx.Close();
            //for(int i = ds.Tables[0].Rows.Count; i<14; i++) ds.Tables[0].Rows.Add();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Operator";
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 210;
            dataGridView1.Columns[3].Width = 130;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString() != "")
                {
                    row.ContextMenuStrip = Menu;
                    row.Cells[3].Value = row.Cells[3].Value.ToString() == "ad" ? "Administrateur" :
                        row.Cells[3].Value.ToString() == "op" ? "Opérateur" :
                        row.Cells[3].Value.ToString() == "cq" ? "Contrôle qualité" : "N/A";
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifierToolStripMenuItem.PerformClick();
        }
    }
}
