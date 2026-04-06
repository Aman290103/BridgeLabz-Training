using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class Duck : Bird, ISwimmable
    {
        public Duck(string name) : base(name, "Duck") { }
		public void swim()
		{
            Console.WriteLine("Duck swims in a ponds");
		}
	}

  
}
