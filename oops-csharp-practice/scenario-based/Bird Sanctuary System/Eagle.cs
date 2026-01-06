using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class Eagle : Bird, IFlyable
    {
        public Eagle(string name) : base(name, "Eagle") { }

		public void fly()
		{
			Console.WriteLine("Eagle flies high in the sky.");
		}
	}
}

    

