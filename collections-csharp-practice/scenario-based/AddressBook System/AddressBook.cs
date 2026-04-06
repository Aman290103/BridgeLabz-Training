using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.AddressBook_System
{
    public class AddressBook
    {
        // Name of the Address Book
        public string BookName;

        // List to store contacts instead of array
        private List<ContactPerson> contacts = new List<ContactPerson>();

        public List<ContactPerson> Contacts => contacts;

        public int ContactCount => contacts.Count;

        public bool AddContact(ContactPerson person)
        {
            contacts.Add(person);
            return true;
        }

        public void RemoveContactAt(int index)
        {
            contacts.RemoveAt(index);
        }
    }
}
