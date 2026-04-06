using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Smart_Home_Automation_System
{
    public class AC : Appliance, IControllable
    {
        public AC(string name) : base(name) { }
        public void TurnOn()
        {
            Console.WriteLine($"{name} AC is cooling the room to 22°C.");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{name} AC is turned OFF.");
		}
    
    }
}
