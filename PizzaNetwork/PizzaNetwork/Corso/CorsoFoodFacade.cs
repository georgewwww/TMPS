using System;
using PizzaNetwork.Facade;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Corso
{
	public class CorsoFoodFacade : IFoodFacade
	{
		private MaterialsProvider materialsProvider;
		private BakerProvider bakerProvider;
		private PackerProvider packerProvider;

		public CorsoFoodFacade()
		{
			this.materialsProvider = new MaterialsProvider();
			this.bakerProvider = new BakerProvider();
			this.packerProvider = new PackerProvider();
		}

		public void PreparePizza()
		{
			Console.WriteLine("---------------------------------");
			materialsProvider.Get();
			materialsProvider.Cut();
			materialsProvider.Prepare();
			bakerProvider.Bake();
			packerProvider.Pack("pizza");
			Console.WriteLine("---------------------------------");
		}

		public void PrepareSalad()
		{
			Console.WriteLine("---------------------------------");
			materialsProvider.Get();
			materialsProvider.Cut();
			materialsProvider.Mix();
			bakerProvider.AddOil();
			packerProvider.Pack("salad");
			Console.WriteLine("---------------------------------");
		}

		public void PrepareSoup()
		{
			Console.WriteLine("---------------------------------");
			materialsProvider.Get();
			materialsProvider.Prepare();
			materialsProvider.BoilWater();
			materialsProvider.Mix();
			bakerProvider.AddOil();
			packerProvider.Pack("soup");
			Console.WriteLine("---------------------------------");
		}

		public void PrepareSnacks()
		{
			Console.WriteLine("---------------------------------");
			materialsProvider.Get();
			materialsProvider.Prepare();
			bakerProvider.AddSauce();
			packerProvider.Pack("snacks");
			Console.WriteLine("---------------------------------");
		}

		public void PrepareAlcohol()
		{
			Console.WriteLine("---------------------------------");
			materialsProvider.Get();
			packerProvider.Pack("alcohol drinking");
			Console.WriteLine("---------------------------------");
		}
	}
}
