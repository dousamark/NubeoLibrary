using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	class SmsMessage : Message
	{
		public Address SenderAddress;
		public DateTime DateReceived;
		public string Text;

		public SmsMessage(int phoneNumber, Prefix prefix, string text, DateTime date)
		{

		}
	}
}
