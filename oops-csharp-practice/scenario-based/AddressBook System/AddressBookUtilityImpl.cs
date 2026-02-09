using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
	public class AddressBookUtilityImpl : IAddressBook
	{

		private AddressBook[] addressBooks = new AddressBook[10];
		private int bookCount = 0;


		private AddressBook GetOrCreateBook()
		{
			Console.Write("Enter Address Book Name: ");
			string name = Console.ReadLine();

			for (int i = 0; i < bookCount; i++)
			{
				if (addressBooks[i].BookName.Equals(name, StringComparison.OrdinalIgnoreCase))
					return addressBooks[i];
			}

			AddressBook newBook = new AddressBook();
			newBook.BookName = name;
			addressBooks[bookCount++] = newBook;

			Console.WriteLine("New Address Book Created!");
			return newBook;
		}


		//-----------------------updated uc-5 method--------------------------------//
		public void AddContact()
		{
			AddressBook book = GetOrCreateBook();

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

			// ---------------- UC6 (Duplicate Check) ----------------
			for (int i = 0; i < book.ContactCount; i++)
			{
				if (book.Contacts[i].Equals(person))
				{
					Console.WriteLine("Duplicate Contact! Person already exists in this Address Book.");
					return;
				}
			}

			book.AddContact(person);
			Console.WriteLine("Contact Added Successfully!");
		}

		//-----------------------UC - 3-----------------------------//

		// ----------------------- UC 3 (UPDATED FOR UC5 STRUCTURE) -----------------------
		public void EditContact()
		{
			// Select which Address Book to work on
			AddressBook book = GetOrCreateBook();

			if (book.ContactCount == 0)
			{
				Console.WriteLine("No contacts available to edit.");
				return;
			}

			Console.Write("Enter First Name to edit: ");
			string firstName = Console.ReadLine();

			for (int i = 0; i < book.ContactCount; i++)
			{
				if (book.Contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("\nEditing Contact: ");
					Console.WriteLine(book.Contacts[i]);

					Console.Write("Enter New Address: ");
					book.Contacts[i].Address = Console.ReadLine();

					Console.Write("Enter New City: ");
					book.Contacts[i].City = Console.ReadLine();

					Console.Write("Enter New State: ");
					book.Contacts[i].State = Console.ReadLine();

					Console.Write("Enter New Zip: ");
					book.Contacts[i].Zip = Console.ReadLine();

					Console.Write("Enter New Phone Number: ");
					book.Contacts[i].PhoneNumber = Console.ReadLine();

					Console.Write("Enter New Email: ");
					book.Contacts[i].Email = Console.ReadLine();

					Console.WriteLine("\nContact updated successfully!");
					return;
				}
			}

			Console.WriteLine("Contact not found!");
		}


		//-----------------------UC - 4-----------------------------//

		public void DeleteContact()
		{
			// Select Address Book first
			AddressBook book = GetOrCreateBook();

			if (book.ContactCount == 0)
			{
				Console.WriteLine("No contacts available to delete.");
				return;
			}

			Console.Write("Enter First Name to delete: ");
			string firstName = Console.ReadLine();

			for (int i = 0; i < book.ContactCount; i++)
			{
				if (book.Contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
				{
					// Use method from AddressBook class
					book.RemoveContactAt(i);

					Console.WriteLine("Contact deleted successfully!");
					return;
				}
			}

			Console.WriteLine("Contact not found!");
		}

		// ----------------------- UC8 -----------------------
		// Search contacts across all Address Books by City or State
		public void SearchPersonByCityOrState()
		{
			Console.Write("Enter City or State to search: ");
			string place = Console.ReadLine();

			bool found = false;

			// Loop through all Address Books
			for (int b = 0; b < bookCount; b++)
			{
				AddressBook book = addressBooks[b];

				// Loop through contacts in each Address Book
				for (int i = 0; i < book.ContactCount; i++)
				{
					ContactPerson person = book.Contacts[i];

					if (person.City.Equals(place, StringComparison.OrdinalIgnoreCase) ||
						person.State.Equals(place, StringComparison.OrdinalIgnoreCase))
					{
						Console.WriteLine($"Found in Address Book: {book.BookName}");
						Console.WriteLine(person);
						found = true;
					}
				}
			}

			if (!found)
			{
				Console.WriteLine("No persons found in the given City or State.");
			}
		}




	}
}
