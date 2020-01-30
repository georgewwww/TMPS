using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public class CorsoPizzaStore : IPizzaStore
	{
		public void Order(FoodType food)
		{
			Console.WriteLine($"Ordering a '{ food.ToString() }' via Corso Pizza Store...");
		}
	}
}
