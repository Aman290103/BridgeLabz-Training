using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Ride_Hailing_Application
{
		class Program
		{
			static void Main()
			{
				Vehicle v1 = new Car(1, "Ramesh", 15);
				Vehicle v2 = new Bike(2, "Suresh", 8);
				Vehicle v3 = new Auto(3, "Mahesh", 10);

				ProcessRide(v1, 10);
				ProcessRide(v2, 10);
				ProcessRide(v3, 10);
			}

			static void ProcessRide(Vehicle vehicle, double distance)
			{
				Console.WriteLine(vehicle.GetVehicleDetails());

				if (vehicle is IGPS gps)
				{
					gps.UpdateLocation("City Center");
					Console.WriteLine("Current Location: " + gps.GetCurrentLocation());
				}

				Console.WriteLine("Distance: " + distance + " km");
				Console.WriteLine("Fare: " + vehicle.CalculateFare(distance));
				Console.WriteLine("----------------------------------");
			}
		}
	}


