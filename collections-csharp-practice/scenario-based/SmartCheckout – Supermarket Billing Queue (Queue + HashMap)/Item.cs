using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.SmartCheckout___Supermarket_Billing_Queue__Queue___HashMap_
{
	public class Item
	{
		public string Name { get; private set; }
		public double Price { get; private set; }
		public int Stock { get; private set; }

		public Item(string name, double price, int stock)
		{
			Name = name;
			Price = price;
			Stock = stock;
		}

		public bool ReduceStock(int quantity)
		{
			if (Stock >= quantity)
			{
				Stock -= quantity;
				return true;
			}
			return false;
		}
	}

}
