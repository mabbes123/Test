using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AOI
{
    internal class AoiRequest
    {
        public static Main main = new Main();
        public static bool checkUnitOnPresentStation(string data)
        {
            SQLServer.cnx.Open();
            SqlCommand cmd = new SqlCommand(data, SQLServer.cnx);
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            SQLServer.cnx.Close();
            if (res > 0)
                return false;
            else
                return true;
        }
        public static string Insert_Data_AOI(string barcode, string result, string programName, string testerName, string repairOperator, string panelId,
            string panelBarcode, string endDateTime, string refDes, string leadID, string panelResult,
                       string machineCall, string side, string LotNo)
        {
            string sql = "INSERT INTO [TracaAFT].[dbo].[aoi_data] ([creation_time],[barcode_S],[end_date_time_T]," +
                "[lead_id_S],[machine_call_S],[operator_call_S],[panel_barcode_S],[panel_id_S],[panel_result_S]," +
                "[ref_des_S],[result_S],[tester_name_S],[side_S]," +
                "[LotNo]) values (GetDate(),'" + barcode + "',convert(datetime,'" + endDateTime + "',102)," +
                "'" + leadID + "','" + machineCall + "','" + repairOperator + "','" + panelBarcode + "','" + panelId + "','" + panelResult + "'," +
                " '" + refDes + "','" + result + "','" + testerName + "','" + side + "'," +
                " '" + LotNo + "')";
            SQLServer.cnx.Open();
            SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
            int rowsAffected = 0;
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
                SQLServer.cnx.Close();
            }
            catch (Exception ex)
            {
                SQLServer.cnx.Close();
                return ex.Message;
            }
            return "true";
        }
        public static string Insert_Test(string partNumber, string Client, string Partn_Field, string programName, string testerName, string panelId, string panelBarcode,
                      string endDateTime, int panelResult, string side, string aoi, Boolean checkProcess, Boolean CheckInterb)
        {
            string typeTests = "";
            string idBoard = "";
            idBoard = Partn_Field != null && Partn_Field != "" ? GetIdBoard(Client, Partn_Field, partNumber) : "NULL";
            string board = idBoard == "" ? "NULL" : idBoard.ToString();
            if (checkProcess == true)
            {
                typeTests = getTypeTestProcess(aoi, Client, Partn_Field, partNumber);
                Boolean resultCheck = CheckProcess(aoi, panelBarcode, Client, Partn_Field, partNumber, typeTests);
                if (resultCheck == true)
                    panelResult = 1;
                else
                {
                    panelResult = 0;
                    main.lbFilePath.Text = "Attention le numéro de serie " + panelBarcode + " Non Qualifier a " + typeTests;
                    main.lbFilePath.BackColor = Color.DarkRed;
                    main.lbFilePath.ForeColor = Color.White;
                }
            }
            string sql = "INSERT INTO [" + Client + "].[dbo].[Test]([Id_Board],[Num_Serie],[Id_Machine],[DateDebut],[Result],[TypeTest],[Position_Flan],[Side])" +
                " VALUES(" + board + ",'" + panelBarcode + "','" + testerName + "',convert(datetime,'" + endDateTime + "',102)," + panelResult + "," +
                "'" + aoi + "','" + panelId + "','" + side + "') ";

            SQLServer.cnx.Open();
            SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
            int rowsAffected = 0;
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
                SQLServer.cnx.Close();
            }
            catch (Exception ex)
            {
                SQLServer.cnx.Close();
                return ex.Message;
            }
            return "true";
        }
        public static Boolean CheckProcess(string typeTest, string panelBarcode, string Client, string Partn_Field, string partNumber, string typeTests)
        {
            Boolean retVal = false;
            if (typeTests != "" && typeTests != null)
            {
                string sql = " select Result from  " + Client + ".[dbo].Test where Num_Serie = '" + panelBarcode + "' and " +
                                "TypeTest = '" + typeTests + "' order by id desc ";
                SQLServer.cnx.Open();
                SqlCommand InqueTypeTest = new SqlCommand(sql, SQLServer.cnx);
                SqlDataReader drInque = InqueTypeTest.ExecuteReader();
                if (drInque.Read())
                {
                    retVal = drInque.GetValue(0).ToString() == "True" ? true : false;
                }
                SQLServer.cnx.Close();
            }
            else
            {
                retVal = true;
            }
            
            return retVal;
        }
        public static string getTypeTestProcess(string typeTest, string Client, string Partn_Field, string partNumber)
        {
            string typeTests = ""; 
            string getPreviewProsses = "SELECT PREC.TypeProcess FROM " + Client + ".[dbo].DetailsProcess ACT  " +
                                " JOIN  " + Client + ".[dbo].DetailsProcess PREC ON (ACT.Order_Process-1 = PREC.Order_Process " +
                                " AND PREC.Id_Process = ACT.Id_Process) " +
                                " JOIN  " + Client + ".[dbo].Board ON Board.Id_Process = ACT.Id_Process " +
                                " WHERE Board." + Partn_Field + " = '" + partNumber + "' " +
                                " AND ACT.TypeProcess = '" + typeTest + "'";
            SQLServer.cnx.Open();
            SqlCommand cmdIsBorad = new SqlCommand(getPreviewProsses, SQLServer.cnx);
            SqlDataReader dr = cmdIsBorad.ExecuteReader();
            if (dr.Read())
                typeTests = dr.GetValue(0).ToString();
            SQLServer.cnx.Close();
            return typeTests;
        }
        public static string GetIdBoard(string Client, string Partn_Field, string partNumber)
        {
            string idBoard = "";
            string GetIdBoardSql = "SELECT  [Id] FROM [" + Client + "].[dbo].[Board] where " + Partn_Field + "='" + partNumber + "'";
            SQLServer.cnx.Open();
            SqlCommand cmdIsBorad = new SqlCommand(GetIdBoardSql, SQLServer.cnx);
            SqlDataReader dr = cmdIsBorad.ExecuteReader();
            if (dr.Read())
                idBoard = dr.GetValue(0).ToString();
            SQLServer.cnx.Close();
            return idBoard;
        }
        public static string TestCreme(string creme)
        {
            string test = "";
            string sql = " USE TracaAFT " +
                  " SELECT UID, " +
                  "  CASE " +
                  "         WHEN Out_Frigo_Date IS NULL THEN -1000 " +
                  "         WHEN GetDate() > Expiration_Date THEN -2000  " +
                  "         WHEN (Oppening_Date IS NOT NULL AND DATEDIFF(SECOND, Oppening_Date, GetDate()) > Part.DelayAfterOppening) THEN -3000 " +
                  "         WHEN DATEDIFF(SECOND, Out_Frigo_Date, GetDate()) > Part.DelayOutFrigot THEN -4000  " +
                  "         WHEN DATEDIFF(SECOND, Out_Frigo_Date, GetDate()) < Part.DelayStabilisation THEN -5000  " +
                  "         ELSE 0  " +
                  "  END AS ErrorCode " +
                  "  FROM Creme JOIN Part ON Creme.Id_Part = Part.Id " +
                  "  WHERE UID = '" + creme + "' ";
            SQLServer.cnx.Open();
            SqlCommand cmdIsBorad = new SqlCommand(sql, SQLServer.cnx);
            SqlDataReader dr = cmdIsBorad.ExecuteReader();
            if (dr.Read())
                test = dr.GetValue(1).ToString();
            SQLServer.cnx.Close();
            if (test == "0")
            {
                string sqlUpdate = "UPDATE Creme SET Oppening_Date = GetDate() WHERE Oppening_Date IS NULL AND UID = '" + creme + "'";
                SQLServer.cnx.Open();
                SqlCommand cmd = new SqlCommand(sqlUpdate, SQLServer.cnx);
                int rowsAffected = 0;
                try
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                    SQLServer.cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SQLServer.cnx.Close();
                }
            }
            return test;
        }
    }
}
