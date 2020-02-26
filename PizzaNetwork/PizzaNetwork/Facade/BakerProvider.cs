using System;

namespace PizzaNetwork.Facade
{
	public class BakerProvider
	{
		public void Bake()
		{
			Console.WriteLine("[!] Baking the materials");
		}

		public void AddOil()
		{
			Console.WriteLine("[!] Adding specific oils");
		}

		public void AddSauce()
		{
			Console.WriteLine("[!] Adding specific sauces");
		}
	}
}
