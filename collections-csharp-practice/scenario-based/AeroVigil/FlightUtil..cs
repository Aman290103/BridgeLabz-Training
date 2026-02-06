using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practice.AeroVigil
{
    public class FlightUtil : IFlightUtil
    {
		public bool validateFlightNumber(string flightNumber)
		{
			string pattern = @"^FL-[1-9]\d{3}$";
			if (!Regex.IsMatch(flightNumber, pattern)) 
			{
				throw new InvalidFlightException($"The flight number {flightNumber} is invalid");
			}
			return true;
		}

		public bool validateFlightName(string flightName) 
		{
			string pattern = @"^(SpiceJet|Vistara|IndiGo|Air Arabia)$";
			if (!Regex.IsMatch(flightName, pattern, RegexOptions.IgnoreCase)) 
			{
				throw new InvalidFlightException($"The flight name {flightName} is invalid");
			}
			return true;
		}
		public bool validatePassengerCount(int passengerCount, string flightName) 
		{
			int maxCapacity = 0;
			if (flightName == "Spicejet")
			{
				maxCapacity = 396;
			}
			else if (flightName == "Vistara")
			{
				maxCapacity = 615;
			}
			else if (flightName == "Indigo")
			{
				maxCapacity = 230;
			}
			else if(flightName == "Air Arabia")
			{
				maxCapacity = 130;
			}

			if(passengerCount<=0 || passengerCount > maxCapacity) 
			{
				throw new InvalidFlightException($"The passenger count {passengerCount} is invalid for {flightName}.");
			}
			return true;
		}

		public double calculateFuelToFilltank(string flightName, double currentFuelLevel)
		{
			double tankcapacity = 0;

			if (flightName == "SpiceJet") 
			{
				tankcapacity = 200000;
			}
			else if (flightName == "Vistara")
			{
				tankcapacity = 300000;
			}
			else if (flightName == "Indigo") 
			{
				tankcapacity = 250000;
			}
			else if (flightName == "Air Arabia") 
			{
				tankcapacity = 150000;
			}

			if(currentFuelLevel < 0 || currentFuelLevel > tankcapacity) 
			{
				throw new InvalidFlightException($"Invalid fuel level for {flightName}.");
			}
			return tankcapacity-currentFuelLevel;
		}


	}

	
}
