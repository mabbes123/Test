using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
#pragma warning disable CS8602
namespace AOI
{
    internal class ReadXmlFile
    {
        public static Main main = new Main();
        public static Dictionary<string, string> getRootData(string doc)
        {
            Dictionary<string, string> hashRootData = new Dictionary<string, string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(doc);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("//AUTOEXPORTFILE");
            string Barcode = "", Result = "", ProgramName = "", TesterName = "", RepairOperator = "", LotNo="";
            foreach (XmlNode node in nodeList)
            {
                Barcode = node.SelectSingleNode("Barcode").InnerText;
                Result = node.SelectSingleNode("Result").InnerText;
                ProgramName = node.SelectSingleNode("ProgramName").InnerText;
                TesterName = node.SelectSingleNode("TesterName").InnerText;
                RepairOperator = node.SelectSingleNode("RepairOperator").InnerText;
                hashRootData.Add("Barcode", Barcode);
                hashRootData.Add("Result", Result);
                hashRootData.Add("ProgramName", ProgramName);
                hashRootData.Add("TesterName", TesterName);
                hashRootData.Add("RepairOperator", RepairOperator);
                hashRootData.Add("LotNo", LotNo);
            }
            return hashRootData;
        }
        public static List<PabelData> getPanelData(string doc)
        {
            //Dictionary<string, object> hashMapAllMarking = new Dictionary<string, object>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(doc);
            XmlNodeList nodeMarkingList = xmlDoc.DocumentElement.SelectNodes("//PanelData");
            string EndDateTime = "", PanelID = "", PanelBarcode = "", PanelResult = "";
            int increment = 0;
            List<PabelData> list = new List<PabelData>();
            foreach (XmlNode node in nodeMarkingList)
            {
                increment++;

                EndDateTime = node.SelectSingleNode("EndDateTime").InnerText;
                PanelID = node.SelectSingleNode("PanelID").InnerText;
                PanelBarcode = node.SelectSingleNode("PanelBarcode").InnerText;
                PanelResult = node.SelectSingleNode("PanelResult").InnerText;
                list.Add(new PabelData { EndDateTime = EndDateTime, PanelID = PanelID, PanelBarcode = PanelBarcode, PanelResult = PanelResult });
            }
            //hashMapAllMarking.Add("PANELDATA" + increment, list);
            return list;
        }
        public static List<InspectionData> GetInspectionData(string doc)
        {
            Dictionary<string, object> hashMapAllInspection = new Dictionary<string, object>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(doc);
            XmlNodeList nodeMapAllInspection = xmlDoc.DocumentElement.SelectNodes("//InspectionData");
            string Panel_ID = "", PanelBarCode = "", RefDes = "", PadId = "", MachineCall = "", packageName="", LeadID="", RepairStatus="",OperatorCall="";
            int indice = 1;
            List<InspectionData> listInspectionResult = new List<InspectionData>();
            foreach (XmlNode node in nodeMapAllInspection)
            {
                Panel_ID = node.SelectSingleNode("PanelID").InnerText;
                PanelBarCode = node.SelectSingleNode("PanelBarCode").InnerText;
                RefDes = node.SelectSingleNode("RefDes").InnerText;
                MachineCall = node.SelectSingleNode("MachineCall").InnerText;
                LeadID = node.SelectSingleNode("PadId").InnerText;
                listInspectionResult.Add(new InspectionData { PanelID = Panel_ID, PanelBarCode = PanelBarCode, RefDes = RefDes,
                    CompPartNo = PadId,  PackageName = packageName, LeadID = LeadID, MachineCall = MachineCall, RepairStatus= RepairStatus,
                    OperatorCall = OperatorCall
                });
            }
            //hashMapAllInspection.Add("InspectionData" + indice, listInspectionResult);
            return listInspectionResult;
        }
        public static string displaySPIData(Dictionary<string, string> hashRootData, List<PabelData> hashMapAllMarking, List<InspectionData> hashMapAllInspection, string fileName)
        {
            /*********************/
            string Client = "", Partn_Field = "", ProgramSplit = "", NumSerie = "";
            Boolean CheckProces = false, AoiForm = false; ;
            /*******************/
            string resultatSql = "", barcode = "", result = "", programName = "", testerName = "", panelId = "";
            string panelBarcode = "", endDateTime = "", panelResult = "", repairOperator = "", LotNo = "";
            barcode = hashRootData["Barcode"];
            result = hashRootData["Result"];
            programName = hashRootData["ProgramName"];
            testerName = hashRootData["TesterName"];
            repairOperator = hashRootData["RepairOperator"];
            LotNo = hashRootData["LotNo"];
            string side = getSide(programName);
            if(programName != null && programName != "")
                 ProgramSplit = fileName.Substring(0, 3);
            if(ProgramSplit != "")
            {
                string sql = "SELECT [Client],[Partn_Field],[CheckProcess],[TypeAOI] FROM [TracaAFT].[dbo].[setupTraca145] where [ProgramName] ='" + ProgramSplit + "'";
                SQLServer.cnx.Open();
                SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);              
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Client      = dr.GetString(0);
                    Partn_Field = dr.GetString(1);
                    try { CheckProces = (Boolean)dr.GetBoolean(2); } catch { };
                    try { AoiForm = (Boolean)dr.GetBoolean(3); } catch { };
                }
                    SQLServer.cnx.Close();
            }
            if (result == "GOOD" || result == "PASS")
            {
                main.lblStatus.Text = "Le Produit est BON";
                main.lblStatus.BackColor = Color.Green;
                main.lblStatus.ForeColor = Color.White;
            }
            else
            {
                main.lblStatus.Text = "Le Produit est NG";
                main.lblStatus.BackColor = Color.DarkRed;
                main.lblStatus.ForeColor = Color.White;
            }

            for (var x = 0; x < hashMapAllMarking.Count(); x++)
            {
                var data = hashMapAllMarking[x];
                panelId = data.PanelID;
                panelBarcode = data.PanelBarcode;
                endDateTime = data.EndDateTime;
                panelResult = data.PanelResult;
                panelId = data.PanelID;
                if ((panelBarcode == "" || panelBarcode == null) && (barcode != null && barcode != "")&&(barcode.Length >8))
                    panelBarcode = barcode;
                string refDes = "";
                string compPartNo = "";
                string leadID = "";
                string machineCall = "";
                if (panelBarcode != null & panelBarcode != "")
                {

                    for (int z = 0; z < hashMapAllInspection.Count(); z++)
                    {
                        var InspecData = hashMapAllInspection[z];
                        string insPanelId = InspecData.PanelID;
                        if (insPanelId == panelId)
                        {
                            if (refDes == "")
                                refDes = InspecData.RefDes;
                            else
                                refDes = refDes + "," + InspecData.RefDes;
                            if (machineCall == "")
                                machineCall = InspecData.MachineCall;
                            else
                                machineCall = machineCall + "," + InspecData.MachineCall;
                            if (compPartNo == "")
                                compPartNo = InspecData.CompPartNo;
                            else
                                compPartNo = compPartNo + "," + InspecData.CompPartNo;
                            if (leadID == "")
                                leadID = InspecData.LeadID;
                            else
                                leadID = leadID + "," + InspecData.LeadID;
                        }
                    }
                    string SPI = "";
                    if (NumSerie == "") { NumSerie = "'" + panelBarcode + "'"; } else { NumSerie += ",'" + panelBarcode + "'"; }
                    if(AoiForm == true) { SPI = getSPISide(side); } else { SPI = "SPI"; }
                    if (result == "PASS" || result == "GOOD") { var res = 1; } else { var res = 0; }
                    main.gridInfo.Rows.Add(
                        Client, Partn_Field, barcode, result, programName, testerName, repairOperator, panelId, panelBarcode, panelResult,
                        endDateTime, refDes, leadID,machineCall, side, LotNo, SPI, CheckProces
                        );
                }
                else {                  
                    return "-1000";
                }
            }
            if (Client != null & Client != "")
            {

                if (side != null && side != "")
                {
                    resultatSql = "SELECT [Result]  FROM [" + Client + "].[dbo].[Test] where Num_Serie in  (" + NumSerie + ") and  side = '" + side + "' and result=1";
                }
                else
                {
                    resultatSql = "SELECT [Result]  FROM [" + Client + "].[dbo].[Test] where Num_Serie in  (" + NumSerie + ") and result=1";
                }
            }
            else
            {
                return "-2000";
            }
            return resultatSql;
        }
        public static string getPatFromProgrameName(string programName)
        {
            string[] programArray = programName.Split("\\");
            string[] splitPart    = programArray[programArray.Length-1].Split(" ");
            return splitPart[0];
        }
        public static string getSide(string programName)
        {
            string side = "";
            if (programName.IndexOf(" F1") != -1)
            {
                side = "BOT";
            }
            else if (programName.IndexOf(" F2") != -1)
            {
                side = "TOP";
            }
            else if (programName.IndexOf("_F1") != -1)
            {
                side = "BOT";
            }
            else if (programName.IndexOf("_F2") != -1)
            {
                side = "TOP";
            }
            return side;
        }
        public static string getSPISide(string side)
        {
            if (side == "F1")
            {
                return "SPI-B";
            }
            else if (side == "F2")
            {
                return "SPI-T";
            }
            else {
                return "SPI";
            }
        }
        public static string GetNameFile(string file)
        {
            string[] SplitNameFile = file.Split("\\");
            int count = SplitNameFile.Count();
            string fileName = SplitNameFile[count - 1];
            return fileName;
        }
        public static string convertDateTime(string endDateTime)
        {
            string[] date = endDateTime.Split("-");
            return  date[0].Replace(":","/") +" "+ date[1];

        }
        public static int resultStrToBit(string panelResult)
        {
            if (panelResult == "GOOD" || panelResult == "PASS")
                return 1;
            else
                return 0;
        }
    }
}
