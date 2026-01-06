using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
    public class Bike : Vehicle,IRental
    {
        public Bike(int id, string name, double rent) : base(id, name, rent) { }

        public override double CalculateRent(int days)
        {
            return rentPerDay * days;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Bike Details");
            base.DisplayInfo();
        }

    }
}
