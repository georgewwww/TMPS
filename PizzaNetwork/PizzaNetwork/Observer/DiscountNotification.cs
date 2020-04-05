using System.Collections.Generic;

namespace PizzaNetwork.Observer
{
	public class DiscountNotification : INotification
	{
		private List<ICustomer> _customers = new List<ICustomer>();

		public int DiscountState { get; set; }

		public void Attach(ICustomer customer)
		{
			_customers.Add(customer);
		}

		public void Detach(ICustomer customer)
		{
			_customers.Remove(customer);
		}

		public void Notify()
		{
			foreach (var item in _customers)
			{
				item.Update();
			}
		}

	}
}
