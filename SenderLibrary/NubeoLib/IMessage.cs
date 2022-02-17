using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public interface IMessage
	{
		string Text
		{
			get;
			set;
		}
			
		DateTime DateReceived 
		{
			get;
		}

		string ToString();
	}
}
