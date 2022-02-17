using System;
using System.Collections.Generic;
using System.Text;

namespace NubeoLib
{
    public enum Prefix
    {
        Czech = 420,
        Slovak = 421,
        German = 49,
        International = 1,
    }

    public enum ListType
    {
        ReceivedUnread = 0,
        ReceivedRead = 1,
        StoredUnsent = 2,
        StoredSent = 3,
        All = 4
    }

    public class Address
    {
        public Prefix prefix;
        public int phoneNumber;

        public Address(int phoneNumber, Prefix prefix)
        {
            this.phoneNumber = phoneNumber;
            this.prefix = prefix;
        }
    }

}
