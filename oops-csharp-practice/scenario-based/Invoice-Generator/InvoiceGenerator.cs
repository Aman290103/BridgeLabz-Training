using System;
using InvoiceGenerator.Services;

namespace InvoiceGenerator{
	public class Program{
		public static void Main(){
			Console.WriteLine("===== Invoice Generator for Freelancers =====\n");

			Console.Write("Enter invoice details: ");
			string input = Console.ReadLine();

			// Create objects
			InvoiceParser parser = new InvoiceParser();
			InvoiceCalculator calculator = new InvoiceCalculator();

			// Parse invoice
			var invoiceItems = parser.ParseInvoice(input);

			// Display invoice
			Console.WriteLine("\nInvoice Details:");
			Console.WriteLine("----------------------------");
			foreach (var item in invoiceItems){
				Console.WriteLine($"{item.TaskName} : {item.Amount} INR");
			}

			// Calculate total
			int total = calculator.GetTotalAmount(invoiceItems);

			Console.WriteLine("----------------------------");
			Console.WriteLine($"Total Amount: {total} INR");
			Console.WriteLine("----------------------------");
		}
	}
}
