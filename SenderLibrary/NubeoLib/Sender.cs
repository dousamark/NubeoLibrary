using System;
using System.Collections.Generic;
using System.Text;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Program")]

namespace NubeoLib
{
	class Sender
	{
		public static void TestMessage(String user)
		{
			Console.WriteLine(user + " says hi");
		}
	}
}
