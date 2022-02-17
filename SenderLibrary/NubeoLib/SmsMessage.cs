using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	class SmsMessage : Message
	{
		private Address senderAddress;
		public Address SenderAddress => senderAddress;

		private DateTime dateReceived;
		public DateTime DateReceived => dateReceived;

		private string text;
		public string Text    
		{
			get => text;
			set => text = value;
		}

		public SmsMessage(int phoneNumber, Prefix prefix, string text, DateTime dateReceived)
		{
			this.senderAddress = new Address(phoneNumber, prefix);
			this.text = text;
			this.dateReceived = dateReceived;
		}

		public override string ToString()
		{
			return @"This message has been recieved at " + dateReceived.ToString() +
				" from a number " + senderAddress.prefix + senderAddress.phoneNumber +
				" and says " + text;
		}
	}
}
