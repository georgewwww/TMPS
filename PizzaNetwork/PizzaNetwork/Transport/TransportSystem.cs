using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class TransportSystem : ITransport
	{
		private readonly ITransport customTransport;

		public TransportSystem(ITransport customTransport)
		{
			this.customTransport = customTransport;
		}
			
		public void Send()
		{
			Console.WriteLine("\nSending package to the courier...");
			customTransport.Send();
		}
	}
}
