namespace PizzaNetwork.Observer
{
	public interface INotification
	{
		void Attach(ICustomer customer);
		void Detach(ICustomer customer);
		void Notify();
	}
}
