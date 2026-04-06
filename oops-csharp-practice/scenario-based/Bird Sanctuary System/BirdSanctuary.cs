using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Bird_Sanctuary_System
{
    public class BirdSanctuary
    {
        public static void Main(string[] args)
        {
            Bird[] birds =
            {
                new Eagle("Sky Hunter"),
                new Sparrow("Cutie"),
                new Duck("Donald Duck"),
                new Penguin("Pengu"),
                new Seagull("Sea Rat")
            };

            Console.WriteLine("\n-------Bird Sanctuary---------\n");

            foreach(Bird bird in birds)
            {
                bird.displayInfo();

                if(bird is IFlyable flyableBird)
                {
                    flyableBird.fly();
                }
                if(bird is ISwimmable swimmableBird)
                {
                    swimmableBird.swim();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
