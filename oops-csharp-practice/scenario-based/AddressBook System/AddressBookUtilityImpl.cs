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

		

	}
}
