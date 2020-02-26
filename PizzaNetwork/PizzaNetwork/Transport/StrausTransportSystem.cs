using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class StrausTransportSystem : ITransport
	{
		private readonly IVehicle customTransport;

		public StrausTransportSystem(IVehicle customTransport)
		{
			this.customTransport = customTransport;
		}

		public void Request()
		{
			Console.WriteLine("\nSending the package to the Straus courier...");
			customTransport.Send();
		}
	}
}
