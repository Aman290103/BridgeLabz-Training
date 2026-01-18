using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
    public class AddressBookUtilityImpl : IAddressBook
	{
		
		private ContactPerson[] contacts = new ContactPerson[100];
		int Contactcount = 0;

		//-----------------------UC 1 + UC 2--------------------------------//
		public void AddContact()
		{
			if (Contactcount >= contacts.Length)
			{
				Console.WriteLine("Address Book is Full!");
				return;
			}
			ContactPerson person = new ContactPerson();

			Console.Write("Enter First Name : ");
			person.FirstName = Console.ReadLine();
			Console.Write("Enter Last Name  : ");
			person.LastName = Console.ReadLine();
			Console.Write("Enter Address    : ");
			person.Address = Console.ReadLine();
			Console.Write("Enter City       : ");
			person.City = Console.ReadLine();
			Console.Write("Enter State      : ");
			person.State = Console.ReadLine();
			Console.Write("Enter Zip        : ");
			person.Zip = Console.ReadLine();
			Console.Write("Enter Phone No   : ");
			person.PhoneNumber = Console.ReadLine();
			Console.Write("Enter Email      : ");
			person.Email = Console.ReadLine();
			contacts[Contactcount] = person;
			Contactcount++;
			Console.WriteLine("\nContact Added Successfully!");
		}

		//-----------------------UC - 3-----------------------------//

		public void EditContact()
		{
			if (Contactcount == 0)
			{
				Console.WriteLine("No contacts available to edit.");
				return;
			}

			Console.WriteLine("Enter First Name to edit: ");
			string firstName = Console.ReadLine();


			for (int i = 0; i < Contactcount; i++)
			{
				if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
	            { 
					Console.WriteLine("\nEditing Contact: ");
					Console.WriteLine(contacts[i]);

					Console.Write("Enter New Address: ");
					contacts[i].Address = Console.ReadLine();

					Console.Write("Enter New City: ");
					contacts[i].City = Console.ReadLine();

					Console.Write("Enter New State: ");
					contacts[i].State = Console.ReadLine();

					Console.Write("Enter New Zip: ");
					contacts[i].Zip = Console.ReadLine();

					Console.Write("Enter New Phone Number: ");
					contacts[i].PhoneNumber = Console.ReadLine();

					Console.Write("Enter New Email: ");
					contacts[i].Email = Console.ReadLine();

					Console.WriteLine("\nContact updated successfully!");
					return;
				}
			}

			Console.WriteLine("Contact not found!");
		}

		//-----------------------UC - 4-----------------------------//

		public void DeleteContact()
		{
			if (Contactcount == 0)
			{
				Console.WriteLine("No contacts available to delete.");
				return;
			}

			Console.Write("Enter First Name to delete: ");
			string firstName = Console.ReadLine();

			for (int i = 0; i < Contactcount; i++)
			{
				if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
				{
					// Shift contacts to left
					for (int j = i; j < Contactcount - 1; j++)
					{
						contacts[j] = contacts[j + 1];
					}

					contacts[Contactcount - 1] = null;
					Contactcount--;

					Console.WriteLine("Contact deleted successfully!");
					return;
				}
			}

			Console.WriteLine("Contact not found!");
		}





	}
}
