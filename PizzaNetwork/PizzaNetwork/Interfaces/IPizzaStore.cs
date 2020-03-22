using PizzaNetwork.Enums;

namespace PizzaNetwork.Interfaces
{
	public interface IPizzaStore
	{
		void Order(IFoodCollection foodCollection);
	}
}
