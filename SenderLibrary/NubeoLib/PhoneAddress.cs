using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
	public class PhoneAddress : Address
	{
        private Prefix prefix;
        public Prefix Prefix
        {
            get => prefix;
            set => prefix = value;
        }

        private int phoneNumber;
        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public PhoneAddress(int phoneNumber, Prefix prefix)
        {
            this.phoneNumber = phoneNumber;
            this.prefix = prefix;
        }
    }
}
