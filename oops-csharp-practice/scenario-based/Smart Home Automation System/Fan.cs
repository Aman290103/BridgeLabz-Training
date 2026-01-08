using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Smart_Home_Automation_System
{
    public class Fan : Appliance, IControllable
    {
        public Fan(string name) : base(name) { }
        public void TurnOn()
        {
            Console.WriteLine($"{name} Fan is rotating at medium speed.");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{name} fan is turned OFF.");
		}
    
    }
}
