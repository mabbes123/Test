using System.Data;
using Microsoft.Data.SqlClient;

namespace AOI
{
    public partial class Utilisateurs : Form
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }
        // ---------------------------------------------------------------------------------------------------
        // FORM ACTIONS
        private void Useres_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Operator> users = Operator.getAll();
            foreach (Operator user in users)
            {
                dataGridView1.Rows.Add(user.Id.ToString(), user.First_Name, user.Last_Name, user.Login, user.Type, user.Creation_Date.ToString());
            }
        }
        // ---------------------------------------------------------------------------------------------------
        // DATA TABLE ACTIONS
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                supprimerToolStripMenuItem.Enabled = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == Operator.current.Login ? false : true;
                modifierToolStripMenuItem.Enabled = true;
            }
        } 
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifierToolStripMenuItem.PerformClick();
        }
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            supprimerToolStripMenuItem.Enabled = false;
            modifierToolStripMenuItem.Enabled = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Selected = false;
        }
        // ---------------------------------------------------------------------------------------------------
        // MENU ITEMS ACTIONS
        private void Actualiser_Click(object sender, EventArgs e)
        {
            this.Useres_Load(sender, e);
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if(new Utilisateur().ShowDialog() == DialogResult.OK)
            { 
                this.Useres_Load(sender, e);
            }
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operator user = Operator.getByLogin(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                if (new Utilisateur(user.Login, user.First_Name, user.Last_Name, user.Type).ShowDialog() == DialogResult.OK)
                    this.Useres_Load(sender, e);
            }
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() != "")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!Operator.deleteByLogin(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()))
                        MessageBox.Show("Un erreur s'est produit. Impossible de supprimer cet utilisateur.\nL'action à été annuler.", "Erruer SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Useres_Load(sender, e);
                }
            }
        }
        // ---------------------------------------------------------------------------------------------------
        // MENU ITEMS SHORTCUT
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
        }
    }
}
