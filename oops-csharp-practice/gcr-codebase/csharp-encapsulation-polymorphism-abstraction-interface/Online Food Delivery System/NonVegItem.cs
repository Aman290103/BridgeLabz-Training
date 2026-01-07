using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Online_Food_Delivery_System
{
		public class NonVegItem : FoodItem, IDiscountable
		{
			public NonVegItem(string name, double price, int quantity)
				: base(name, price, quantity) { }

			public override double CalculateTotalPrice()
			{
				return (Price * Quantity) + 50; // Extra non-veg charge
			}

			public double ApplyDiscount()
			{
				return CalculateTotalPrice() * 0.05; // 5% discount
			}

			public string GetDiscountDetails()
			{
				return "Non-Veg Item Discount: 5%";
			}
		}
	
}
