using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	class PhoneConnection : Connection
	{

		public PhoneConnection()
		{

		}
		public PhoneConnection(string connection)
		{

		}

		public void ShowProgress(string message)
		{
			Console.WriteLine(message);
		}

		public void Send(SmsMessage message)
		{

		}

	}
}
