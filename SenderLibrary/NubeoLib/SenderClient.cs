using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.IO.Ports;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Program")]

namespace NubeoLib
{
	public class SenderClient 
	{
		private readonly string username;
		public string Username => username;

		private readonly string password;
		public string Password => password;

		private List<Device> devices;
		public List<Device> Devices 
		{
			get { return devices; }
			set{devices = value;}
		}

		private Dictionary<Device,IMessage> senderBox;
		public Dictionary<Device, IMessage> SenderBox
		{
			get { return senderBox; }
			set { senderBox = value; }
		}
		
		public SenderClient() { }

		public SenderClient(string username, string password)
		{
			this.username = username;
			this.password = password;
			this.devices = new List<Device>();
			this.senderBox = new Dictionary<Device, IMessage>();
		}

		public void AddDeviceToList(Device device)
		{
			devices.Add(device);
		}

		public void AddMessageToSenderBox(Device device, IMessage message)
		{
			//checks if client has device from which message will be sent
			if (devices.Contains(device))
			{
				senderBox.Add(device,message);
			}
			else
			{
				Console.WriteLine("Client doesn't use this device.");
			}
		}

		//Empties users senderbox by sending messages and then clearing Dictionary
		public void SendSenderBox()
		{
			foreach(KeyValuePair<Device, IMessage> message in SenderBox)
			{
				message.Key.SendMessage(message.Value);
			}
			EmptySenderBox();
		}

		private void EmptySenderBox()
		{
			this.senderBox.Clear();
		}
	}
}
