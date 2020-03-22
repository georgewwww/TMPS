using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Food;
using PizzaNetwork.Interfaces;
using PizzaNetwork.Transport;

namespace PizzaNetwork.Andys
{
	public class AndysPizzaStore : IPizzaStore
	{
		public AndysPizzaStore()
		{
			Console.WriteLine("\n....::: ANDY'S PIZZA STORE :::....");
		}

		public void Order(IFoodCollection foodCollection)
		{
			var quantity = 0;

			var foodFacade = new AndysFoodFacade();
			var iterator = foodCollection.CreateIterator();

			Console.WriteLine("\nStarting to prepare this command.");

			var item = (FoodObject)iterator.First();
			while (item != null)
			{
				Console.WriteLine($"\nPreparing {item.foodType.ToString()}...");
				switch (item.foodType)
				{
					case FoodType.Pizza:
						foodFacade.PreparePizza();
						break;
					case FoodType.Salad:
						foodFacade.PrepareSalad();
						break;
					case FoodType.Soup:
						foodFacade.PrepareSoup();
						break;
					case FoodType.Snacks:
						foodFacade.PrepareSnacks();
						break;
					case FoodType.Alcohol:
						foodFacade.PrepareAlcohol();
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(item.foodType));
				}
				quantity += item.quantity;

				item = (FoodObject)iterator.Next();
			}

			if (quantity > 4)
			{
				var transport = new CarTransport();
				ITransport transportSystem = new StrausTransportSystem(transport);
				transportSystem.Request();
			}
			else
			{
				var transport = new BikeTransport();
				ITransport transportSystem = new StrausTransportSystem(transport);
				transportSystem.Request();
			}
		}
	}
}
