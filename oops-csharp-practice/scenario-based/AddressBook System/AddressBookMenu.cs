using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
	sealed class AddressBookMenu
	{
		private IAddressBook addressBook;

		public AddressBookMenu()
		{
			addressBook = new AddressBookUtilityImpl();
		}

		public void ShowMenu()
		{
			while (true)
			{
				Console.WriteLine("\n1. Add Contact");
				Console.WriteLine("2. Edit Contact");
				Console.WriteLine("3. Delete Contact");
				Console.WriteLine("4. Search Person by City or State");
				Console.WriteLine("5. View Persons by City or State");
				Console.WriteLine("6. Count Contacts by City or State");
				Console.WriteLine("7. Sort Contacts Alphabetically");

				Console.WriteLine("8. Exit");

				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						addressBook.AddContact();
						break;

					case 2:
						addressBook.EditContact();
						break;

					case 3:
						addressBook.DeleteContact();
						break;

						//-------------uc - 8-----------//
					case 4:
						addressBook.SearchPersonByCityOrState();
						break;

						//------------UC -9----------------//

					case 5:
						addressBook.ViewPersonsByCityOrState();
						break;

					case 6:
    						addressBook.CountPersonsByCityOrState();
						break;

					case 7:
    						addressBook.SortContactsByName();
    						break;		
					case 8:
						Console.WriteLine("Exiting Address Book System...");
						return;
				}
			}
		}

	}
}



