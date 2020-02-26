using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public class Program
	{
		internal static void StoreMenu(IFranchise franchise)
		{
			Console.WriteLine("Please choose a store:");
			Console.WriteLine("[1] Andy's Pizza");
			Console.WriteLine("[2] Corso Pizza");
			var storeId = Convert.ToInt32(Console.ReadLine());
			IPizzaStore pizzaStore;
			switch (storeId)
			{
				case 1:
					pizzaStore = franchise.GetAndysPizzaStore();
					Menu(pizzaStore);
					break;
				case 2:
					pizzaStore = franchise.GetCorsoPizzaStore();
					Menu(pizzaStore);
					break;
				default:
					return;
			}
		}

		internal static void Menu(IPizzaStore pizzaStore)
		{
			Console.WriteLine("[1] Pizza");
			Console.WriteLine("[2] Salad");
			Console.WriteLine("[3] Soup");
			Console.WriteLine("[4] Snacks");
			Console.WriteLine("[5] Alcohol\n");
			var itemId = Convert.ToInt32(Console.ReadLine());
			Console.Write("Quantity: ");
			var quantity = Convert.ToInt32(Console.ReadLine());

			if (itemId >= 1 && itemId <= 5)
			{
				pizzaStore.Order((FoodType)itemId, quantity);
			}
		}

		static void Main(string[] args)
		{
			var franchise = Franchise.GetInstance(); 
			StoreMenu(franchise);
		}
	}
}
