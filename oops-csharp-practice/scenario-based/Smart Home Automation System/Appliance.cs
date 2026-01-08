using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Smart_Home_Automation_System
{
    public abstract class Appliance 
    {
        public string name;

        public Appliance(string name)
        {
            this.name = name;
		}

        string Name
        {
            get { return name; }
		}



	}
}
