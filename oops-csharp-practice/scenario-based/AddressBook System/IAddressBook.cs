using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.AddressBook_System
{
    public interface IAddressBook
    {
        public void AddContact();
        public void EditContact();
        
        //------uc4-------------//
        public void DeleteContact();
	}
}
