using SPI.Properties;
using Microsoft.Data.SqlClient;

public static class SQLServer
{
	public static SqlConnection cnx = null;
	public static void Connect()
    {
        String connectionString = @"Data Source=" + Resources.DataSource + "; Initial Catalog=" + Resources.InitialCatalog + "; User ID=" + Resources.UserId + "; Password=" + Resources.Password + "";
        cnx = new SqlConnection(connectionString);
    }
}
