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
            if (Validator.checkArgs(args))
			{
                int phoneNumber = int.Parse(args[0]);
                Prefix prefix = (Prefix)Enum.Parse(typeof(Prefix), args[1], true);
                
                //TODO: ne jako args 2 ale concatnout od 2 do konce args.len
                string textMessage = args[2];
                DateTime dateSent = DateTime.Now;

                PhoneConnection phoneConnection = new PhoneConnection();

                Console.WriteLine("Sending message...");
                try
                {
                    phoneConnection.Send(new SmsMessage(phoneNumber, prefix,textMessage, dateSent));
                    Console.WriteLine("Message Sent!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to list messages: " + ex.ToString());
                }
            }
			else
			{
				Console.WriteLine("Wrong input of args. Check ReadMe file under Instuctions.");
			}
        }
    }
}
