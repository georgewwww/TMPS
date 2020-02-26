using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class CarTransport : ITransport
	{
		public string Name { get; set; }

		public CarTransport(string name)
		{
			this.Name = name;
		}

		public void Send()
		{
			Console.WriteLine($"Sending the package with {Name}.");
		}
	}
}
