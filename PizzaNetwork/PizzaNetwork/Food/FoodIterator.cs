using PizzaNetwork.Interfaces;

namespace PizzaNetwork.Food
{
	public class FoodIterator : IIterator
	{
		private FoodCollection _foodCollection;
		private int _current = 0;

		public FoodIterator(FoodCollection foodCollection)
		{
			_foodCollection = foodCollection;
		}

		public object Current()
		{
			return _foodCollection[_current];
		}

		public object First()
		{
			return _foodCollection[0];
		}

		public bool IsDone()
		{
			return _current >= _foodCollection.Count;
		}

		public object Next()
		{
			object ret = null;
			if (_current < _foodCollection.Count - 1)
			{
				ret = _foodCollection[++_current];
			}

			return ret;
		}
	}
}
