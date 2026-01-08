using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Smart_Home_Automation_System
{
    public class Light : Appliance, IControllable
    {
        public Light(string name) : base(name){ }
        public void TurnOn()
        {
            Console.WriteLine($"{name} Light is glowing softly..");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{name} light is turned OFF.");
		}
 
    }
}
