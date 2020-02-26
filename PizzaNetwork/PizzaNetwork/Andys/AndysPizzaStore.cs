using System;
using PizzaNetwork.Enums;
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

		public void Order(FoodType food, int quantity)
		{
			Console.WriteLine($"\nInitializing order for {food.ToString()}...");
			var foodFacade = new AndysFoodFacade();
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
				var transport = new CarTransport("White Car");
				var transportSystem = new TransportSystem(transport);
				transportSystem.Execute();
			}
			else
			{
				var transport = new BikeTransport("Blumarine Bike");
				var transportSystem = new TransportSystem(transport);
				transportSystem.Execute();
			}
		}
	}
}
