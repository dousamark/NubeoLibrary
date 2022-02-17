using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public class SmsMessage : IMessage
	{
		private PhoneAddress senderAddress;
		public PhoneAddress SenderAddress => senderAddress;

		private PhoneAddress recieverAddress;
		public PhoneAddress RecieverAddress => recieverAddress;

		private DateTime dateRecieved;
		public DateTime DateReceived => dateRecieved;

		private string text;
		public string Text    
		{
			get => text;
			set => text = value;
		}

		public SmsMessage(PhoneAddress from, PhoneAddress to, string text, DateTime dateReceived)
		{
			this.senderAddress = from;
			this.recieverAddress = to;
			this.text = text;
			this.dateRecieved = dateReceived;
		}

		//overriding ToString for intuitive converting content to string
		public override string ToString()
		{
			return @"This message has been recieved at " + dateRecieved.ToString() +
				" from a number " + (int)senderAddress.prefix + senderAddress.phoneNumber +
				" to a number " + (int)recieverAddress.prefix + recieverAddress.phoneNumber +
				" and says: \"" + text + "\"";
		}
	}
}
