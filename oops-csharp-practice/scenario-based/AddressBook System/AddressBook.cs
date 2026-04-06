using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
    public class AddressBook
    {
		// Name of the Address Book (unique)
		public string BookName;

		// Array to store contacts inside this Address Book
		private ContactPerson[] contacts = new ContactPerson[100];

		// Keeps track of how many contacts are stored
		private int contactCount = 0;

		// Property to expose contacts array (read-only access)
		public ContactPerson[] Contacts => contacts;

		// Property to expose number of contacts
		public int ContactCount => contactCount;

		// Method to add a new contact into this Address Book
		public bool AddContact(ContactPerson person)
		{
			// Check if address book is full
			if (contactCount >= contacts.Length)
			{
				Console.WriteLine("Address Book is Full!");
				return false;
			}

			// Add contact and increment count
			contacts[contactCount++] = person;
			return true;
		}

		// Method to remove a contact at a specific index
		public void RemoveContactAt(int index)
		{
			// Shift elements to left after deletion
			for (int i = index; i < contactCount - 1; i++)
				contacts[i] = contacts[i + 1];

			// Reduce count and clear last position
			contacts[--contactCount] = null;
		}
	}
}
