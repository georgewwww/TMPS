namespace PizzaNetwork.Interfaces
{
	public interface IIterator
	{
		object First();
		object Next();
		bool IsDone();
		object Current();
	}
}
