using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Online_Food_Delivery_System
{
		public class VegItem : FoodItem, IDiscountable
		{
			public VegItem(string name, double price, int quantity)
				: base(name, price, quantity) { }

			public override double CalculateTotalPrice()
			{
				return Price * Quantity; // No extra charge
			}

			public double ApplyDiscount()
			{
				return CalculateTotalPrice() * 0.10; // 10% discount
			}

			public string GetDiscountDetails()
			{
				return "Veg Item Discount: 10%";
			}
		}
	}


