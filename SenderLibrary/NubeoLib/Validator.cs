using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public static class Validator
	{
		public static bool CheckArgs(string[] args)
		{
			if (IsInNameDatabase(args[0]) && CorrectPassword(args[0],args[1]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static bool CorrectPassword(string user, string passw)
		{
			return true;
		}

		private static bool IsInNameDatabase(string v)
		{
			//for further implementation
			return true;
		}
	}
}
