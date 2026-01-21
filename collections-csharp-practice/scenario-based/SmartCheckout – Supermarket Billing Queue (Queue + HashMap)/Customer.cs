using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.SmartCheckout___Supermarket_Billing_Queue__Queue___HashMap_
{
	public class Customer
	{
		public string Name { get; private set; }
		public Dictionary<string, int> Cart { get; private set; }

		public Customer(string name)
		{
			Name = name;
			Cart = new Dictionary<string, int>();
		}

		public void AddItem(string itemName, int quantity)
		{
			if (Cart.ContainsKey(itemName))
				Cart[itemName] += quantity;
			else
				Cart[itemName] = quantity;
		}
	}
}
