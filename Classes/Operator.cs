using Microsoft.Data.SqlClient;
namespace AOI
{
	public class Operator
	{
		public static Operator? current = null;

		public int Id { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Type { get; set; }
		public DateTime Creation_Date { get; set; }

		public Operator()
		{
			this.Id = 0;
			this.First_Name = "";
			this.Last_Name = "";
			this.Login = "";
			this.Password = "";
			this.Type = "op";
			this.Creation_Date = DateTime.Now;
		}

		public Operator(int Id_, string First_Name_, string Last_Name_, string Login_, string Password_, string Type_, DateTime Creation_Date_)
		{
			this.Id = Id_;
			this.First_Name = First_Name_;
			this.Last_Name = Last_Name_;
			this.Login = Login_;
			this.Password = Password_;
			this.Type = Type_;
			this.Creation_Date = Creation_Date_;
		}

		public static List<Operator> getAll()
		{
			List<Operator> users = new List<Operator>();
			Operator user = new Operator();
			SQLServer.cnx.Open();
			String sql = "SELECT * FROM Operator";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				user = new Operator();
				user.Id = dr.GetInt32(0);
				try { user.First_Name = dr.GetString(1); }catch (Exception) { user.First_Name = ""; }
				try { user.Last_Name = dr.GetString(2); } catch (Exception) { user.Last_Name = ""; }
				try { user.Login = dr.GetString(3); }catch (Exception) { user.Login = ""; }
				try { user.Password = dr.GetString(4); }catch (Exception) { user.Password = ""; }
				user.Type = dr.GetString(5);
				user.Creation_Date = dr.GetDateTime(6);
				users.Add(user);
			}
			SQLServer.cnx.Close();
			return users;
		}

		public static Operator getByLoginPassword(string login, string password)
		{
			Operator user = null;
			SQLServer.cnx.Open();
			String sql = "SELECT TOP(1) * FROM Operator WHERE login='" + login + "' AND password='" + password + "'";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
				user = new Operator(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetDateTime(6));
			SQLServer.cnx.Close();
			return user;
		}
		public static Operator getByLogin(string login)
		{
			Operator user = null;
			SQLServer.cnx.Open();
			String sql = "SELECT TOP(1) * FROM Operator WHERE login='" + login + "'";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
				user = new Operator(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetDateTime(6));
			SQLServer.cnx.Close();
			return user;
		}
		public static Operator getById(int id)
		{
			Operator user = null;
			SQLServer.cnx.Open();
			String sql = "SELECT TOP(1) * FROM Operator WHERE Id=" + id;
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
				user = new Operator(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetDateTime(6));
			SQLServer.cnx.Close();
			return user;
		}

		public static Boolean deleteByLogin(string login)
		{
			SQLServer.cnx.Open();
			String sql = "DELETE FROM Operator WHERE login='" + login + "'";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			int rowsAffected = cmd.ExecuteNonQuery();
			SQLServer.cnx.Close();
			return rowsAffected > 0;
		}

		public static Boolean Create(Operator u)
		{
			SQLServer.cnx.Open();
			String sql = "INSERT INTO Operator (Login, Password, First_Name, Last_Name, Type) VALUES " +
				"('" + u.Login + "', '" + u.Password + "', '" + u.First_Name + "', '" + u.Last_Name + "', '" + u.Type + "')";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			int rowsAffected = cmd.ExecuteNonQuery();
			SQLServer.cnx.Close();
			return rowsAffected > 0;
		}

		public static Boolean Update(Operator u)
		{
			SQLServer.cnx.Open();
			String sql = "UPDATE Operator SET Password = '" + u.Password + "', First_Name = '" + u.First_Name + "', Last_Name = '" + u.Last_Name + "', Type = '" + u.Type + "' " +
				"WHERE Login = '" + u.Login + "'";
			SqlCommand cmd = new SqlCommand(sql, SQLServer.cnx);
			int rowsAffected = cmd.ExecuteNonQuery();
			SQLServer.cnx.Close();
			return rowsAffected > 0;
		}
	}
}
