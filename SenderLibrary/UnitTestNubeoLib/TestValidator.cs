using Microsoft.VisualStudio.TestTools.UnitTesting;
using NubeoLib;
using System.Collections.Generic;

namespace UnitTestNubeoLib
{
	[TestClass]
	class TestValidator
	{
		[TestMethod]
		public void CheckArgs_ArgsShouldPass()
		{
			//arrange
			string[] args = new string[] { "DemoUser", "PaperlessToBrighterFuture"};

			//act
			List<SenderClient> users = new List<SenderClient>
			{
				new SenderClient("DemoUser", "PaperlessToBrighterFuture")
			};
			bool TestValidityOutput = Validator.CheckUsersInDatabase(args,users);

			//assert
			Assert.AreEqual(true, TestValidityOutput);
		}

		[TestMethod]
		public void CheckArgs_WrongPassword()
		{
			//arrange
			string[] args = new string[] { "DemoUser", "PaperlessToWorseFuture"};

			//act
			List<SenderClient> users = new List<SenderClient>
			{
				new SenderClient("DemoUser", "PaperlessToBrighterFuture")
			};
			bool TestValidityOutput = Validator.CheckUsersInDatabase(args, users);

			//assert
			Assert.AreEqual(false, TestValidityOutput);
		}

		[TestMethod]
		public void CheckArgs_UserNotFound()
		{
			//arrange
			string[] args = new string[] { "DemoUserrr", "PaperlessToBrighterFuture" };

			//act
			List<SenderClient> users = new List<SenderClient>
			{
				new SenderClient("DemoUser", "PaperlessToBrighterFuture")
			};
			bool TestValidityOutput = Validator.CheckUsersInDatabase(args, users);

			//assert
			Assert.AreEqual(false, TestValidityOutput);
		}
	}
}
