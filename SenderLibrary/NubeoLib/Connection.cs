﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	interface Connection
	{
		void Send(SmsMessage message);
	}
}
