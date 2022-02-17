using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NubeoLib;
using System.Linq;

namespace UnitTestNubeoLib
{
	[TestClass]
	class TestSqliteDataAccess
	{
		[TestMethod]
		public void SqliteDataAccess_CorrectUsersFromDB()
		{
			//arrange
			List<SenderClient> expectedUsers = new List<SenderClient>();
			expectedUsers.Add(new SenderClient("DemoUser", "PaperlessToBrighterFuture"));

			//act
			List<SenderClient> actualUsers = SqliteDataAccess.LoadClients();
			bool TestValidityOutput = expectedUsers.SequenceEqual(actualUsers); ;

			//assert
			CollectionAssert.AreEqual(expectedUsers, actualUsers);
		}

		[TestMethod]
		public void SqliteDataAccess_WrongUsersFromDB()
		{
			//arrange
			List<SenderClient> expectedUsers = new List<SenderClient>();
			expectedUsers.Add(new SenderClient("DemoUserrr", "PaperlessToBrighterFuture"));

			//act
			List<SenderClient> actualUsers = SqliteDataAccess.LoadClients();
			bool TestValidityOutput = expectedUsers.SequenceEqual(actualUsers); ;

			//assert
			CollectionAssert.AreNotEqual(expectedUsers, actualUsers);
		}
	}
}
