using PizzaNetwork.Andys;
using PizzaNetwork.Corso;
using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public sealed class Franchise : IFranchise
	{
		private Franchise() {}
		private static Franchise _instance;

		public static Franchise GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Franchise();
			}

			return _instance;
		}

		public IPizzaStore GetAndysPizzaStore()
		{
			return new AndysPizzaStore();
		}

		public IPizzaStore GetCorsoPizzaStore()
		{
			return new CorsoPizzaStore();
		}

	}
}
