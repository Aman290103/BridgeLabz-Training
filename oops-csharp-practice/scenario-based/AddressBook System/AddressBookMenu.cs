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
					Console.WriteLine("4. Exit");

					int choice = Convert.ToInt32(Console.ReadLine());

					switch (choice)
					{
						case 1:
							addressBook.AddContact();  
							break;

					case 2 : 
							addressBook.EditContact();
							break;

					case 3:
							addressBook.DeleteContact();
						break;

					case 4:
						return;
					}
				}
			}
			
	}
}



