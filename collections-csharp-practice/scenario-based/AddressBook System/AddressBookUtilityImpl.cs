using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabzTraining.AddressBook_System
{
    public class AddressBookUtilityImpl : IAddressBook
    {
        // UC5 — Multiple Address Books using Dictionary
        private Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

        // UC9 — City/State mapping using Dictionary
        private Dictionary<string, List<ContactPerson>> cityMap = new Dictionary<string, List<ContactPerson>>();
        private Dictionary<string, List<ContactPerson>> stateMap = new Dictionary<string, List<ContactPerson>>();

        private AddressBook GetOrCreateBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new AddressBook { BookName = name };
                Console.WriteLine("New Address Book Created!");
            }

            return addressBooks[name];
        }

        // ---------------- UC6 + UC7 ----------------
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

            if (book.Contacts.Contains(person))
            {
                Console.WriteLine("Duplicate Contact! Not Added.");
                return;
            }

            book.AddContact(person);

            // UC9 Mapping
            if (!cityMap.ContainsKey(person.City))
                cityMap[person.City] = new List<ContactPerson>();
            cityMap[person.City].Add(person);

            if (!stateMap.ContainsKey(person.State))
                stateMap[person.State] = new List<ContactPerson>();
            stateMap[person.State].Add(person);

            Console.WriteLine("Contact Added Successfully!");
        }

        // ---------------- UC3 ----------------
        public void EditContact()
        {
            AddressBook book = GetOrCreateBook();
            Console.Write("Enter First Name to edit: ");
            string firstName = Console.ReadLine();

            var person = book.Contacts.FirstOrDefault(p => p.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.Write("Enter New Address: ");
            person.Address = Console.ReadLine();
            Console.Write("Enter New City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter New State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter New Zip: ");
            person.Zip = Console.ReadLine();
            Console.Write("Enter New Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter New Email: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully!");
        }

        // ---------------- UC4 ----------------
        public void DeleteContact()
        {
            AddressBook book = GetOrCreateBook();
            Console.Write("Enter First Name to delete: ");
            string firstName = Console.ReadLine();

            var person = book.Contacts.FirstOrDefault(p => p.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            book.Contacts.Remove(person);
            Console.WriteLine("Contact deleted successfully!");
        }

        // ---------------- UC8 ----------------
        public void SearchPersonByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string place = Console.ReadLine();

            var results = addressBooks.Values
                .SelectMany(book => book.Contacts)
                .Where(p => p.City.Equals(place, StringComparison.OrdinalIgnoreCase)
                         || p.State.Equals(place, StringComparison.OrdinalIgnoreCase));

            foreach (var p in results)
                Console.WriteLine(p);
        }

        // ---------------- UC9 ----------------
        public void ViewPersonsByCityOrState()
        {
            Console.Write("View by (1) City or (2) State? ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                foreach (var city in cityMap.Keys)
                {
                    Console.WriteLine($"\nCity: {city}");
                    foreach (var person in cityMap[city])
                        Console.WriteLine(person);
                }
            }
            else
            {
                foreach (var state in stateMap.Keys)
                {
                    Console.WriteLine($"\nState: {state}");
                    foreach (var person in stateMap[state])
                        Console.WriteLine(person);
                }
            }
        }

        // ---------------- UC10 ----------------
        public void CountPersonsByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string place = Console.ReadLine();

            int cityCount = cityMap.ContainsKey(place) ? cityMap[place].Count : 0;
            int stateCount = stateMap.ContainsKey(place) ? stateMap[place].Count : 0;

            Console.WriteLine($"Total persons in {place}: {cityCount + stateCount}");
        }

        // ---------------- UC11 ----------------
        public void SortContactsByName()
        {
            AddressBook book = GetOrCreateBook();
            var sorted = book.Contacts.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            foreach (var p in sorted)
                Console.WriteLine(p);
        }

        // ---------------- UC12 ----------------
        public void SortByCity()  => PrintSorted(GetOrCreateBook().Contacts.OrderBy(p => p.City));
        public void SortByState() => PrintSorted(GetOrCreateBook().Contacts.OrderBy(p => p.State));
        public void SortByZip()   => PrintSorted(GetOrCreateBook().Contacts.OrderBy(p => p.Zip));

        private void PrintSorted(IEnumerable<ContactPerson> list)
        {
            foreach (var p in list)
                Console.WriteLine(p);
        }
    }
}
