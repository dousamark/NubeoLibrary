using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public class PhoneAddress : Address
	{
        public Prefix prefix;
        public int phoneNumber;

        public PhoneAddress(int phoneNumber, Prefix prefix)
        {
            this.phoneNumber = phoneNumber;
            this.prefix = prefix;
        }
    }
}
