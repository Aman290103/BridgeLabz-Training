using System;
using System.Collections.Generic;
using InvoiceGenerator.Models;

namespace InvoiceGenerator.Services{
	public class InvoiceParser{
		public List<InvoiceItem> ParseInvoice(string input){
			List<InvoiceItem> items = new List<InvoiceItem>();

			string[] tasks = input.Split(',');
			foreach (string task in tasks){
				string[] parts = task.Split('-');
				if (parts.Length != 2)
					continue;

				string taskName = parts[0].Trim();
				string amountPart = parts[1].Replace("INR", "").Trim();

				if (int.TryParse(amountPart, out int amount)){
					items.Add(new InvoiceItem
					{
						TaskName = taskName,
						Amount = amount
					});
				}
			}

			return items;
		}
	}
}
