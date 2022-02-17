using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public static class Validator
	{
		internal static bool CheckUsersInDatabase(string[] args, List<SenderClient> users)
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
