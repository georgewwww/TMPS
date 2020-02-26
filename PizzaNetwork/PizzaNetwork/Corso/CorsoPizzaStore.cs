using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Interfaces;
using PizzaNetwork.Transport;

namespace PizzaNetwork.Corso
{
	public class CorsoPizzaStore : IPizzaStore
	{
		public CorsoPizzaStore()
		{
			Console.WriteLine("\n....::: CORSO PIZZA STORE :::....");
		}

		public void Order(FoodType food, int quantity)
		{
			Console.WriteLine($"\nInitializing order for {food.ToString()}...");
			var foodFacade = new CorsoFoodFacade();
			switch (food)
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
					throw new ArgumentOutOfRangeException(nameof(food), food, null);
			}

			if (quantity > 4)
			{
				var transport = new CarTransport();
				var transportSystem = new StrausTransportSystem(transport);
				transportSystem.Request();
			}
			else
			{
				var transport = new BikeTransport();
				var transportSystem = new StrausTransportSystem(transport);
				transportSystem.Request();
			}
		}
	}
}
