using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.SmartCheckout___Supermarket_Billing_Queue__Queue___HashMap_
{
	public class Program
	{
		public static void Main()
		{
			// Add items to store
			CheckoutUtility.AddItemToStore("Milk", 50, 10);
			CheckoutUtility.AddItemToStore("Bread", 30, 20);
			CheckoutUtility.AddItemToStore("Eggs", 10, 50);

			// Create customers
			Customer c1 = new Customer("Aman");
			c1.AddItem("Milk", 2);
			c1.AddItem("Bread", 1);

			Customer c2 = new Customer("Raj");
			c2.AddItem("Eggs", 12);
			c2.AddItem("Milk", 1);

			// Add to queue
			CheckoutUtility.EnqueueCustomer(c1);
			CheckoutUtility.EnqueueCustomer(c2);

			// Process checkout
			CheckoutUtility.ProcessNextCustomer();
			CheckoutUtility.ProcessNextCustomer();
		}
	}
}
