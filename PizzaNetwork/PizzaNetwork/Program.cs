using System;
using PizzaNetwork.Enums;

namespace PizzaNetwork
{
	class Program
	{
		static void Main(string[] args)
		{
			var andysPizzaStore = Franchise.Instance.PizzaNetwork.GetAndysPizzaStore();
			andysPizzaStore.Order(FoodType.Pizza);

		}
	}
}
