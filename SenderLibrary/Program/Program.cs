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
            PhoneConnection phoneConnection = new PhoneConnection();

            phoneConnection.ShowProgress("Sending message...");
            try
            {
                phoneConnection.Send(new SmsSubmitMessage(new Address("46730000000", TypeOfAddress.International, NumberingPlan.ISDNOrPhone), "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ1abcdefghijklmnopqrstuvwxyzåäö2ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ3abcdefghijklmnopqrstuvwxyzåäö4ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ5abcdefghijklmnopqrstuvwxyzåäö6ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ7abcdefghijklmnopqrstuvwxyzåäö8ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ9abcdefghijklmnopqrstuvwxyzåäö0"));
                phoneConnection.ShowProgress("Message Sent!");
            }
            catch (Exception ex)
            {
                phoneConnection.ShowProgress("Failed to list messages: " + ex.ToString());
            }
            

        }
    }
}
