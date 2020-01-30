using PizzaNetwork.Interfaces;

namespace PizzaNetwork
{
	public sealed class Franchise
	{
		public static Franchise Instance { get; } = new Franchise();

		public IPizzaNetwork PizzaNetwork { get; set; }

		public Franchise()
		{
			PizzaNetwork = new PizzaNetwork();
		}
	}
}
