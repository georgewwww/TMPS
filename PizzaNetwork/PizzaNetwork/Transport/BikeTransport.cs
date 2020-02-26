using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class BikeTransport : ITransport
	{
		public string Name { get; set; }

		public BikeTransport(string name)
		{
			this.Name = name;
		}

		public void Send()
		{
			Console.WriteLine($"Sending the package with {Name}.");
		}
	}
}
