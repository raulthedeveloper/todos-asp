using System;
using DataLayer.Connection;

namespace DataLayer.Connection
{
	public class DbInstance
	{
		DbConnection dbConnection = new DbConnection();


		public DbInstance()
		{
		}

		public void InitializeDb()
		{
			dbConnection.Server = "Example";
            dbConnection.DatabaseName = "Todo";
            dbConnection.UserName = "UserName";
            dbConnection.Password = "Password";

			dbConnection.IsConnect();
		}


	}
}

