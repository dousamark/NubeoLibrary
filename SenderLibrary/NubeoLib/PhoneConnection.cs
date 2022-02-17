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

		public void Send(SmsMessage message)
		{
			Console.WriteLine(message.ToString());
		}

	}
}
