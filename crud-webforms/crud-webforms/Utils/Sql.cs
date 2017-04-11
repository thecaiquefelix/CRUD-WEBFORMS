using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crud_webforms.Utils
{
	public class Sql
	{

		public static SqlConnection OpenConnection()
		{
			SqlConnection conn = new SqlConnection("Server=tcp:crud-webforms.database.windows.net,1433;Database=crud-webforms;User ID=caique;Password=mudar123!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

			conn.Open();

			return conn;

		}

	}
}