using System;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Transport
{
	public class CarTransport : IVehicle
	{
		public void Send()
		{
			Console.WriteLine("Sending the package with car.");
		}
	}
}
