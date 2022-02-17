using Microsoft.VisualStudio.TestTools.UnitTesting;
using NubeoLib;

namespace UnitTestNubeoLib
{
	[TestClass]
	public class TestValidator
	{
		[TestMethod]
		public void CheckArgs_ArgsShouldPass()
		{
			//arrange
			string[] args = new string[] { "DemoUser", "PaperlessToBrighterFuture"};

			//act
			bool TestValidityOutput = Validator.CheckArgs(args);

			//assert
			Assert.AreEqual(true, TestValidityOutput);
		}

		[TestMethod]
		public void CheckArgs_WrongPassword()
		{
			//arrange
			string[] args = new string[] { "DemoUser", "PaperlessToWorseFuture"};

			//act
			bool TestValidityOutput = Validator.CheckArgs(args);

			//assert
			Assert.AreEqual(false, TestValidityOutput);
		}

		[TestMethod]
		public void CheckArgs_UserNotFound()
		{
			//arrange
			string[] args = new string[] { "DemoUserrr", "PaperlessToBrighterFuture" };

			//act
			bool TestValidityOutput = Validator.CheckArgs(args);

			//assert
			Assert.AreEqual(false, TestValidityOutput);
		}
	}
}
