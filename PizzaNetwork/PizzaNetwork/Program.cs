using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Food;
using PizzaNetwork.Interfaces;
using PizzaNetwork.Observer;

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
					Console.Clear();
					pizzaStore = franchise.GetAndysPizzaStore();
					Menu(pizzaStore);
					break;
				case 2:
					Console.Clear();
					pizzaStore = franchise.GetCorsoPizzaStore();
					Menu(pizzaStore);
					break;
				default:
					return;
			}
		}

		internal static void Menu(IPizzaStore pizzaStore)
		{
			var foodCollection = new FoodCollection();
			var count = 0;

			Console.WriteLine("[1] Pizza");
			Console.WriteLine("[2] Salad");
			Console.WriteLine("[3] Soup");
			Console.WriteLine("[4] Snacks");
			Console.WriteLine("[5] Alcohol\n");
			Console.WriteLine("[0] Continue...\n");

			while (true)
			{
				var itemId = Convert.ToInt32(Console.ReadLine());
				if (itemId == 0)
				{
					pizzaStore.Order(foodCollection);
					return;
				}

				Console.Write("Quantity: ");
				var quantity = Convert.ToInt32(Console.ReadLine());

				if (itemId >= 1 && itemId <= 5)
				{
					foodCollection[count++] = new FoodObject((FoodType)itemId, quantity);
				}
			}
		}

		internal static void DiscountInit()
		{
			var discountNotification = new DiscountNotification();
			var customer1 = new Customer(discountNotification, "John Doe");
			var customer2 = new Customer(discountNotification, "Michael Philips");

			discountNotification.Attach(customer1);
			discountNotification.Attach(customer2);

			var rand = new Random().Next(100);
			if (rand > 70)
			{
				Console.WriteLine("Today it's discount day!\nSending notification  to all the customers...\n");
				discountNotification.DiscountState = 20;
				discountNotification.Notify();
			}
			Console.ReadLine();
		}

		static void Main(string[] args)
		{
			DiscountInit();
			var franchise = Franchise.GetInstance(); 
			StoreMenu(franchise);
		}
	}
}
