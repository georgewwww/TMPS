using PizzaNetwork.Enums;

namespace PizzaNetwork.Food
{
	public class FoodObject
	{
		public FoodType foodType { get; set; }
		public int quantity { get; set; }

		public FoodObject(FoodType foodType, int quantity)
		{
			this.foodType = foodType;
			this.quantity = quantity;
		}
	}
}
