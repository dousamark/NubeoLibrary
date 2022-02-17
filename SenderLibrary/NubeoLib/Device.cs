using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	abstract class Device
	{
		public abstract Address Address
		{
			get;
		}

		public virtual void SendMessage(IMessage message) 
		{
			Console.WriteLine(message.ToString());
		}
	}
}
