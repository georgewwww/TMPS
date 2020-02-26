using System;

namespace PizzaNetwork.Facade
{
	public class MaterialsProvider
	{
		public void Get()
		{
			Console.WriteLine("[!] Taking needed materials");
		}

		public void Prepare()
		{
			Console.WriteLine("[!] Preparing the materials");
		}

		public void Cut()
		{
			Console.WriteLine("[!] Cutting the materials");
		}

		public void Mix()
		{
			Console.WriteLine("[!] Mixing materials");
		}

		public void BoilWater()
		{
			Console.WriteLine("[!] Boiling water");
		}
	}
}
