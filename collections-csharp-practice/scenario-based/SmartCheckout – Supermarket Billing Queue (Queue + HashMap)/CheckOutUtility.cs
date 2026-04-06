using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.SmartCheckout___Supermarket_Billing_Queue__Queue___HashMap_
{
	public static class CheckoutUtility
	{
		private static Queue<Customer> customerQueue = new Queue<Customer>();
		private static Dictionary<string, Item> inventory = new Dictionary<string, Item>();

		// Add items to store
		public static void AddItemToStore(string name, double price, int stock)
		{
			inventory[name] = new Item(name, price, stock);
		}

		// Add customer to queue
		public static void EnqueueCustomer(Customer customer)
		{
			customerQueue.Enqueue(customer);
			Console.WriteLine($"{customer.Name} added to queue.");
		}

		// Process customer checkout
		public static void ProcessNextCustomer()
		{
			if (customerQueue.Count == 0)
			{
				Console.WriteLine("No customers in queue.");
				return;
			}

			Customer customer = customerQueue.Dequeue();
			double total = 0;

			Console.WriteLine($"\nProcessing {customer.Name}'s bill:");

			foreach (var item in customer.Cart)
			{
				string itemName = item.Key;
				int quantity = item.Value;

				if (inventory.ContainsKey(itemName))
				{
					Item storeItem = inventory[itemName];

					if (storeItem.ReduceStock(quantity))
					{
						double cost = storeItem.Price * quantity;
						total += cost;
						Console.WriteLine($"{itemName} x{quantity} = {cost}");
					}
					else
					{
						Console.WriteLine($"{itemName} is out of stock!");
					}
				}
				else
				{
					Console.WriteLine($"{itemName} not found in store!");
				}
			}

			Console.WriteLine($"Total Bill: {total}");
		}
	}
}
