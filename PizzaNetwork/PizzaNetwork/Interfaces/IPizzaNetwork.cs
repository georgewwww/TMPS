namespace PizzaNetwork.Interfaces
{
	public interface IPizzaNetwork
	{
		IPizzaStore GetAndysPizzaStore();
		IPizzaStore GetCorsoPizzaStore();
	}
}
