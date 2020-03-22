using PizzaNetwork.Food;

namespace PizzaNetwork.Interfaces
{
	public interface IFoodCollection
	{
		FoodIterator CreateIterator();
	}
}
