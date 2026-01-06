using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
    public class VehicleRental
    {
        public static void Main(string[] args)
        {
            Vehicle bike = new Bike(8201, "Splendor", 200);
            Vehicle car = new Car(8301, "Swift", 600);
            Vehicle truck = new Truck(8401, "Ashok LeyLand", 1000);

            Customer customer = new Customer(22, "Aman");

            customer.RentVehicle(bike, 5);
            customer.RentVehicle(car, 3);
            customer.RentVehicle(truck, 4);
        }
    }
}
