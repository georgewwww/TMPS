using System;

namespace PizzaNetwork.Facade
{
	public class PackerProvider
	{
		public void Pack(string obj)
		{
			Console.WriteLine("[!] Packing the " + obj);
		}
	}
}
