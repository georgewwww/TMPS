using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public class PizzaNetwork : IPizzaNetwork
	{
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
