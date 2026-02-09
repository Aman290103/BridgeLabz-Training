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

		// ---------- UC9 (Simulating Dictionary) ----------//

		// City-wise storage
		private string[] cityList = new string[100];
		private ContactPerson[][] cityPersons = new ContactPerson[100][];
		private int[] cityPersonCount = new int[100];
		private int cityCount = 0;

		// State-wise storage
		private string[] stateList = new string[100];
		private ContactPerson[][] statePersons = new ContactPerson[100][];
		private int[] statePersonCount = new int[100];
		private int stateCount = 0;


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

			// ---------------- UC9: Add person to City mapping ----------------
			int cityIndex = -1;
			for (int i = 0; i < cityCount; i++)
			{
				if (cityList[i].Equals(person.City, StringComparison.OrdinalIgnoreCase))
				{
					cityIndex = i;
					break;
				}
			}

			if (cityIndex == -1)
			{
				cityIndex = cityCount;
				cityList[cityCount] = person.City;
				cityPersons[cityCount] = new ContactPerson[100];
				cityCount++;
			}

			cityPersons[cityIndex][cityPersonCount[cityIndex]++] = person;


			// ---------------- UC9: Add person to State mapping ----------------
			int stateIndex = -1;
			for (int i = 0; i < stateCount; i++)
			{
				if (stateList[i].Equals(person.State, StringComparison.OrdinalIgnoreCase))
				{
					stateIndex = i;
					break;
				}
			}

			if (stateIndex == -1)
			{
				stateIndex = stateCount;
				stateList[stateCount] = person.State;
				statePersons[stateCount] = new ContactPerson[100];
				stateCount++;
			}

			statePersons[stateIndex][statePersonCount[stateIndex]++] = person;

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

		// ----------------------- UC9 -----------------------
		public void ViewPersonsByCityOrState()
		{
			Console.Write("View by (1) City or (2) State? ");
			int choice = int.Parse(Console.ReadLine());

			if (choice == 1)
			{
				for (int i = 0; i < cityCount; i++)
				{
					Console.WriteLine($"\nCity: {cityList[i]}");
					for (int j = 0; j < cityPersonCount[i]; j++)
					{
						Console.WriteLine(cityPersons[i][j]);
					}
				}
			}
			else if (choice == 2)
			{
				for (int i = 0; i < stateCount; i++)
				{
					Console.WriteLine($"\nState: {stateList[i]}");
					for (int j = 0; j < statePersonCount[i]; j++)
					{
						Console.WriteLine(statePersons[i][j]);
					}
				}
			}
			else
			{
				Console.WriteLine("Invalid choice.");
			}
		}

		// ----------------------- UC10 -----------------------
		// Count number of persons in a given City or State
		public void CountPersonsByCityOrState()
		{
		Console.Write("Enter City or State to count persons: ");
		string place = Console.ReadLine();

		int totalCount = 0;

		// Check in City list
		for (int i = 0; i < cityCount; i++)
		{
			if (cityList[i].Equals(place, StringComparison.OrdinalIgnoreCase))
			{
				totalCount += cityPersonCount[i];
			}
		}

		// Check in State list
		for (int i = 0; i < stateCount; i++)
		{
			if (stateList[i].Equals(place, StringComparison.OrdinalIgnoreCase))
			{
				totalCount += statePersonCount[i];
			}
		}

		if (totalCount > 0)
			Console.WriteLine($"Number of contacts in {place}: {totalCount}");
		else
			Console.WriteLine("No contacts found for the given City or State.");
		}

	}
}
