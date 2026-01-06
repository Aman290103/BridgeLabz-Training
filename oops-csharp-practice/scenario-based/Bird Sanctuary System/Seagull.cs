using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name) : base(name, "Seagull") { }

        public void fly()
        {
            Console.WriteLine("Seagull glides over the sea");
        }
        public void swim()
        {
            Console.WriteLine("Seagull swims near the shore");
        }
    }
}
