using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice.AeroVigil
{
    public interface IFlightUtil
    {
        public bool validateFlightNumber(string flightNumber);
        public bool validateFlightName(string flightName);

        public bool validatePassengerCount(int  passengerCount,string flightName);
         public double calculateFuelToFilltank(string flightName, double currentFuelLevel);
    }
}
