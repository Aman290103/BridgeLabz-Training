using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public abstract class Bird
    {
        protected string BirdName;
        protected string species;
        protected Bird(string name,string species) 
        {
            this.BirdName = name;
            this.species = species;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Name : {BirdName}");
            Console.WriteLine($"Species : {species}");
        }
          
    }
}
