using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;

namespace NubeoLib
{
	public class SqliteDataAccess
	{
		//creating a connection for loading database
		public static List<SenderClient> LoadClients()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<SenderClient>("select * from Users", new DynamicParameters());
				return output.ToList();
			}
		}

		//getting ConnectionString from App.config, assuming id is "Default"
		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
