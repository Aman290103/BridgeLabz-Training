using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
    public class ContactPerson
    {
		private string firstName;
		private string lastName;
		private string address;
		private string city;
		private string state;
		private string zip;
		private string phoneNumber;
		private string email;

		public string FirstName { get { return firstName; } set { firstName = value; } }
		public string LastName { get { return lastName; } set { lastName = value; } }
		public string Address { get { return address; } set { address = value; } }
		public string City { get { return city; } set { city = value; } }
		public string State { get { return state; } set { state = value; } }
		public string Zip { get { return zip; } set { zip = value; } }
		public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
		public string Email { get { return email; } set { email = value; } }

		// Override ToString() method for easy display
		public override string ToString()
		{
			return $"Name : {FirstName} {LastName}, Address : {Address}, {City}, {State}, {Zip}, Phone Number : {PhoneNumber}, Email : {Email}";
		}
	}
}
