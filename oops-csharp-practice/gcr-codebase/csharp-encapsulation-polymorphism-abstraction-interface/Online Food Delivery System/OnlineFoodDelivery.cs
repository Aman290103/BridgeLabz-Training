using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Online_Food_Delivery_System
{
		class Program
		{
			static void Main()
			{
				FoodItem item1 = new VegItem("Paneer Butter Masala", 200, 2);
				FoodItem item2 = new NonVegItem("Chicken Biryani", 250, 1);

				ProcessFoodItem(item1);
				ProcessFoodItem(item2);
			}

			static void ProcessFoodItem(FoodItem item)
			{
				Console.WriteLine(item.GetItemDetails());

				double totalPrice = item.CalculateTotalPrice();
				double discount = 0;

				if (item is IDiscountable discountable)
				{
					discount = discountable.ApplyDiscount();
					Console.WriteLine(discountable.GetDiscountDetails());
				}

				Console.WriteLine("Total Price: " + totalPrice);
				Console.WriteLine("Discount: " + discount);
				Console.WriteLine("Final Price: " + (totalPrice - discount));
				Console.WriteLine("----------------------------------");
			}
		}
}
