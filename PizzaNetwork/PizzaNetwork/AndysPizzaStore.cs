using System;
using PizzaNetwork.Enums;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public class AndysPizzaStore : IPizzaStore
	{
		public void Order(FoodType food)
		{
			Console.WriteLine($"Ordering a '{ food.ToString() }' via Andy's Pizza Store...");
		}
	}
}
