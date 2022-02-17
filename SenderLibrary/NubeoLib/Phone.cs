﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	class Phone : Device
	{
		private PhoneAddress address;
		public override Address Address => address;

		public Phone(PhoneAddress address)
		{
			this.address = address;
		}

		public override void SendMessage(IMessage message)
		{
			if(message is SmsMessage smsMessage) 
			{ 
				Console.WriteLine(smsMessage.ToString());
			}
			else
			{
				Console.WriteLine("Via phone only sms can be sent.");
			}
		}
	}
}
