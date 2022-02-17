using System;
using System.IO.Ports;
using NubeoLib;

namespace Program
{
	class Program
	{
		//Entry point
		static void Main(string[] args)
		{
            if (Validator.CheckArgs(args))
			{
                SenderClient client = new SenderClient(args[0]);
                Console.WriteLine("User logged in...");

                Phone phone = new Phone(new PhoneAddress(777111333, Prefix.Czech));
                client.AddDeviceToList(phone);
                Console.WriteLine("User Phone created and connected to user...");

                SmsMessage message = new SmsMessage(
                    (PhoneAddress)phone.Address,
                    new PhoneAddress(777115115, Prefix.Slovak),
                    "Welcome to Nubeo",
                    DateTime.Now);

                client.AddMessageToSenderBox(phone,message);
				Console.WriteLine("Message created and added to the users sender box...");

                client.SendSenderBox();   
                Console.WriteLine("Message Sent!");

            }
			else
			{
				Console.WriteLine("Wrong input of args. Check ReadMe file under Instuctions.");
			}
        }
    }
}
