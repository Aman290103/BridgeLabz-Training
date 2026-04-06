using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Library_Management_System
{
		class Program
		{
			static void Main()
			{
				LibraryItem item1 = new Book(1, "Clean Code", "Robert C. Martin");
				LibraryItem item2 = new Magazine(2, "Time", "Time Editors");
				LibraryItem item3 = new DVD(3, "Inception", "Christopher Nolan");

				ProcessItem(item1);
				ProcessItem(item2);
				ProcessItem(item3);
			}

			static void ProcessItem(LibraryItem item)
			{
				Console.WriteLine(item.GetItemDetails());
				Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

				if (item is IReservable reservable)
				{
					Console.WriteLine("Available: " + reservable.CheckAvailability());
					reservable.ReserveItem();
					Console.WriteLine("Reserved Successfully");
				}

				Console.WriteLine("----------------------------------");
			}
		}
	}


