using System;

namespace BridgeLabz.E_Commerce_Platform
{
	class Program
	{
		static void Main()
		{
			Product[] products =
			{
				new Electronics(1, "Laptop", 60000),
				new Clothing(2, "T-Shirt", 1500),
				new Groceries(3, "Rice", 800)
			};

			PriceCalculator.PrintFinalPrices(products);
		}
	}
}
