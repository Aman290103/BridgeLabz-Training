using System;
using System.Collections.Generic;

namespace BridgeLabz.E_Commerce_Platform
{
	public class PriceCalculator
	{
		public static void PrintFinalPrices(List<Product> products)
		{
			foreach (Product product in products)
			{
				double tax = 0;

				if (product is ITaxable taxable)
				{
					tax = taxable.CalculateTax();
				}

				double discount = product.CalculateDiscount();
				double finalPrice = product.Price + tax - discount;

				Console.WriteLine($"Product: {product.Name}");
				Console.WriteLine($"Base Price: {product.Price}");
				Console.WriteLine($"Tax: {tax}");
				Console.WriteLine($"Discount: {discount}");
				Console.WriteLine($"Final Price: {finalPrice}");
				Console.WriteLine("----------------------------------");
			}
		}
	}
}
