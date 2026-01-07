using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Ride_Hailing_Application
{
		public class Auto : Vehicle, IGPS
		{
			private string _location = "Unknown";

			public Auto(int id, string driver, double rate)
				: base(id, driver, rate) { }

			public override double CalculateFare(double distance)
			{
				return (RatePerKm * distance) + 20; // small fixed charge
			}

			public string GetCurrentLocation()
			{
				return _location;
			}

			public void UpdateLocation(string location)
			{
				_location = location;
			}
		}
	}


