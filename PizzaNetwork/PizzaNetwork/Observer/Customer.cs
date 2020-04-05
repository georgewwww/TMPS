using System;

namespace PizzaNetwork.Observer
{
	public class Customer : ICustomer
	{
		private string _name;
		private int _discountState;
		private DiscountNotification _discountNotification;

		public Customer(DiscountNotification notification, string name)
		{
			_name = name;
			_discountNotification = notification;
		}

		public void Update()
		{
			_discountState = _discountNotification.DiscountState;
			if (_discountState > 0)
			{
				Console.WriteLine($"{_name} was informed abount {_discountState}% discount!");
			}
		}
	}
}
