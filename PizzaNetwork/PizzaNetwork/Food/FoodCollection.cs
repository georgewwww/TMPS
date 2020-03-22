using PizzaNetwork.Interfaces;
using System.Collections;

namespace PizzaNetwork.Food
{
	public class FoodCollection : IFoodCollection
	{
		private ArrayList _items = new ArrayList();

		public FoodIterator CreateIterator()
		{
			return new FoodIterator(this);
		}

		public int Count
		{
			get { return _items.Count; }
		}

		public object this[int index]
		{
			get { return _items[index]; }
			set { _items.Add(value); }
		}
	}
}
