using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.IO.Ports;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Program")]

namespace NubeoLib
{
	class SenderClient 
	{
		public static void TestMessage(String user)
		{
			Console.WriteLine(user + " says hi");
		}
	}
}
