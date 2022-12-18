using SPI.Forms;
using SPI.Properties;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml;
#pragma warning disable CS8602
namespace AOI
{
    public partial class Main : Form
    {
        public static string fileName;
        public static Boolean portComData = true;
        public Main()
        {
            InitializeComponent();
            this.userName.Text = "" + Operator.current.First_Name[0] + Operator.current.Last_Name[0];
            this.userName2.Text = "" + Operator.current.First_Name[0] + Operator.current.Last_Name[0];
            this.userName3.Text = Operator.current.First_Name + " " + Operator.current.Last_Name;
            var str = Operator.current.Type.Equals("ad") == true ? "Administrateur" :
                Operator.current.Type.Equals("cq") == true ? "Contrôle Qualité" :
                Operator.current.Type.Equals("op") == true ? "Opérateur" : "N/A";
            this.mode.Text = "Mode: " + str;
            this.Text = "Solder Paste Inspection ("+Resources.Name+") | Utilisateur : " + Operator.current.First_Name + " " + Operator.current.Last_Name;
            if (Operator.current.Type == "ad")
            {
                this.UserPanel.Height = 166;
                this.UserManager.Enabled = true; this.UserManager.Top = 83;
            }
            else
            {
                if (Operator.current.Type == "cq")
                {
                    this.UserPanel.Height = 125;
                    this.UserManager.Enabled = false;
                }
                else
                {
                    UserPanel.Height = 125;
                    UserManager.Enabled = false;
                }
            }
            ReadXmlFile.main = this;


        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment fermer votre saission ?", "Déconnecter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new Authentification(Operator.current.Login).Show();
            }
        }

        private void userName_Click(object sender, EventArgs e)
        {
            UserPanel.Visible = true;
        }

        private void UserManager_Click(object sender, EventArgs e)
        {
            UserPanel.Visible = false;
            new Utilisateurs().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int test = 1;
            if ((checkCreme.Checked && Creme.Text != "") || (!checkCreme.Checked))
            {
                if (checkCreme.Checked)
                {
                    string res = AoiRequest.TestCreme(Creme.Text);
                    if (res != "0")
                    {
                      switch (res)
                        {
                        case "-1000":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème n'est pas au CMS.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        case "-2000":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème expirée.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        case "-3000":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème ouvert et périmée.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        case "-4000":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème périmée.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        case "-5000":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème en attente de stabilisation.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        case "":
                            {
                                test = 0;
                                portComData = false;
                                timer1.Stop();
                                button1.Enabled = true;
                                button2.Enabled = false;
                                MessageBox.Show("Crème n'existe pas.", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Creme.Focus();
                                break;
                            }
                        }
                    }
                }
                if (test == 1)
                {
                    string[] Files = Directory.GetFiles(Resources.Path, "*.xml");
                    foreach (var file in Files)
                    {
                        fileName = ReadXmlFile.GetNameFile(file);
                        Dictionary<string, string> hashRootData = ReadXmlFile.getRootData(file);
                        List<PabelData> hashMapAllMarking = ReadXmlFile.getPanelData(file);
                        List<InspectionData> hashMapAllInspection = ReadXmlFile.GetInspectionData(file);
                        string data = ReadXmlFile.displaySPIData(hashRootData, hashMapAllMarking, hashMapAllInspection, fileName);
                        switch (data)
                        {
                            case "-1000":
                                portComData = false;
                                lblStatus.Text = "";
                                lblStatus.BackColor = Color.Transparent;
                                lbFilePath.Text = "Attention le numéro de serie carte non Lu !!!";
                                lbFilePath.BackColor = Color.DarkRed;
                                lbFilePath.ForeColor = Color.White;
                                File.Move(Resources.Path + "/" + fileName, Resources.Path + "/" + fileName);
                                break;
                            case "-2000":
                                portComData = false;
                                lblStatus.Text = "";
                                lblStatus.BackColor = Color.Transparent;
                                lbFilePath.Text = " Attention, Client introuvable merci de contacter l'équipe traçabilité (IT) !!!";
                                File.Move(Resources.Path + "/" +  fileName, Resources.Path + "/" + fileName);
                                lbFilePath.BackColor = Color.DarkRed;
                                lbFilePath.ForeColor = Color.White;
                                gridInfo.Rows.Clear();
                                break;
                            default:
                                bool CheckExiste = AoiRequest.checkUnitOnPresentStation(data);
                                if (!CheckExiste)
                                {
                                    lbFilePath.Text = " Attention Carte Déja passée !!!";
                                    lbFilePath.BackColor = Color.DarkRed;
                                    lbFilePath.ForeColor = Color.White;
                                    File.Move(Resources.Path + "/"  + fileName, Resources.Path + "/" + fileName);
                                }
                                break;
                        }
                        hashMapAllMarking.Clear();
                        hashRootData.Clear();
                        hashMapAllInspection.Clear();
                    }
                    timer1.Stop();
                    timer2.Start();
                }
            }
            else
            {
                timer1.Stop();
                button1.Enabled = true;
                button2.Enabled = false;
                MessageBox.Show("Check Créme & Laser est activée.\nVeuillez saisie la crème SVP.", "Check Creme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Creme.Focus();
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<gridInfo.RowCount;i++)
            {
                string Client           = gridInfo.Rows[i].Cells[0].Value.ToString();
                string Partn_Field      = gridInfo.Rows[i].Cells[1].Value.ToString();
                string barcode          = gridInfo.Rows[i].Cells[2].Value.ToString();
                string result           = gridInfo.Rows[i].Cells[3].Value.ToString();
                string programName      = gridInfo.Rows[i].Cells[4].Value.ToString();
                string testerName       = gridInfo.Rows[i].Cells[5].Value.ToString();
                string repairOperator   = gridInfo.Rows[i].Cells[6].Value.ToString();
                string panelId          = gridInfo.Rows[i].Cells[7].Value.ToString();
                string panelBarcode     = gridInfo.Rows[i].Cells[8].Value.ToString();
                string panelResult      = gridInfo.Rows[i].Cells[9].Value.ToString();
                string endDateTime      = gridInfo.Rows[i].Cells[10].Value.ToString();
                string refDes           = gridInfo.Rows[i].Cells[11].Value.ToString();
                string leadID           = gridInfo.Rows[i].Cells[12].Value.ToString();
                string machineCall      = gridInfo.Rows[i].Cells[13].Value.ToString();
                string side             = gridInfo.Rows[i].Cells[14].Value.ToString();
                string LotNo            = gridInfo.Rows[i].Cells[15].Value.ToString();
                string aoi              = gridInfo.Rows[i].Cells[16].Value.ToString();
                Boolean checkProcess    = gridInfo.Rows[i].Cells[17].Value.ToString() == "True" ?true : false;
                string partNumber = ReadXmlFile.getPatFromProgrameName(programName);
                string dateFile = ReadXmlFile.convertDateTime(endDateTime);
                int resultCarte = ReadXmlFile.resultStrToBit(panelResult);
                string spiData = AoiRequest.Insert_Data_AOI(barcode, result, programName, testerName, repairOperator, panelId, panelBarcode,
                     dateFile, refDes, leadID, panelResult, machineCall, side, LotNo);
                string testData = AoiRequest.Insert_Test(partNumber, Client, Partn_Field, programName, testerName, panelId, panelBarcode,
                      dateFile, resultCarte, side, aoi, checkProcess, CheckInterb.Checked);
                if (spiData != "true")
                {
                    portComData = false;
                    timer2.Stop();
                    MessageBox.Show(spiData, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                }
                else if (testData != "true")
                {
                    portComData = false;
                    timer2.Stop();
                    MessageBox.Show(testData, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                }
                else
                {
                    try { File.Move(Resources.Path + "/" + fileName, Resources.Path + "/NoMes/" + fileName); } catch { }
                   
                }
            }
            if(CheckInterb.Checked)
            {
                if(portComData == true)
                {
                    SerialPort comport = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                    comport.Open();
                    comport.Write("true");
                    comport.Close();
                }           
            }
            lblStatus.Text = "";
            lblStatus.BackColor = Color.Transparent;
            lbFilePath.Text = "";
            lbFilePath.BackColor = Color.Transparent;
            gridInfo.Rows.Clear();
            timer2.Stop();
            timer1.Start();
        }

        private void checkCreme_CheckedChanged(object sender, EventArgs e)
        {
            if(new Auth().ShowDialog() == DialogResult.Cancel)
            {
                checkCreme.Checked = !checkCreme.Checked;
            }
        }

        private void CheckInterb_CheckedChanged(object sender, EventArgs e)
        {
            if (new Auth().ShowDialog() == DialogResult.Cancel)
            {
                CheckInterb.Checked = !CheckInterb.Checked;
            }
        } 
    }
}
