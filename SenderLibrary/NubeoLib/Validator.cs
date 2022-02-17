using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	//class for potentional development overseeing all validations
	public static class Validator
	{
		public static bool CheckUsersInDatabase(string[] args, List<SenderClient> users)
		{
			try
			{
				foreach (SenderClient client in users)
				{
					if (client.Username == args[0] && client.Password == args[1])
					{
						return true;
					}
				}
				return false;
			} catch (Exception)
			{
				Console.WriteLine("Incorrect username or password");
				return false;
			}
		}
	}
}
