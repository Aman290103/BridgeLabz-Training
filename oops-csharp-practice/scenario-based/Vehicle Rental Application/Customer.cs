using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
    public class Customer
    {
        public int customerId;
        public string customerName;

        public int CustomerID
        {
            get { return customerId; }
            protected set { customerId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            protected set { customerName = value; }
        }

        public Customer(int customerId, string customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            Console.WriteLine($"\nCustomer Name: {customerName}");
            vehicle.DisplayInfo();
            Console.WriteLine($"Days Rented :  {days}");
            Console.WriteLine($"Total rent : {vehicle.CalculateRent(days)}");
        }
    }
}
