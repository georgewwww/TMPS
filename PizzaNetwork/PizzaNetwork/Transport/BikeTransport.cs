using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class BikeTransport : IVehicle
	{
		public void Send()
		{
			Console.WriteLine("Sending the package with bike.");
		}
	}
}
