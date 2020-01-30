using PizzaNetwork.Enums;

namespace PizzaNetwork.Interfaces
{
	public interface IPizzaStore
	{
		void Order(FoodType food);
	}
}
