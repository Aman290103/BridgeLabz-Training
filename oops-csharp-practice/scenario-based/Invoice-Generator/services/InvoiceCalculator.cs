using System.Collections.Generic;
using InvoiceGenerator.Models;

namespace InvoiceGenerator.Services
{
	public class InvoiceCalculator
	{
		public int GetTotalAmount(List<InvoiceItem> items)
		{
			int total = 0;

			foreach (var item in items)
			{
				total += item.Amount;
			}

			return total;
		}
	}
}
