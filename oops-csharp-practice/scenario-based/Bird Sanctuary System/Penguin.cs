using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class Penguin : Bird, ISwimmable
    {
        public Penguin(string name) : base(name,"Penguin") { }

        public void swim()
        {
            Console.WriteLine("Penguin swims in cold water");
        }
    }
}
