using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
    public abstract class Vehicle : IRental
    {
        protected int vehicleId;
        protected string vehicleName;
        protected double rentPerDay;

        protected Vehicle(int vehicleId,string vehicleName, double rentPerDay)
        {
            this.vehicleId = vehicleId;
            this.vehicleName = vehicleName;
            this.rentPerDay = rentPerDay;
        }

        public abstract double CalculateRent(int days);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"VehicleID : {vehicleId}");
            Console.WriteLine($"VehicleName : {vehicleName}");
            Console.WriteLine($"Rent per day : {rentPerDay}");
        }
    }
}
