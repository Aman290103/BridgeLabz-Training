using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name) : base(name, "Sparrow") { }
		public void fly()
		{
			Console.WriteLine("Sparrow flies at short height");
		}
	}
}