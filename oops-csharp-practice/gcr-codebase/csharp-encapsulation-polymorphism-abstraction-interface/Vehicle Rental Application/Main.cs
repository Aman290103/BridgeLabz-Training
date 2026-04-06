using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
	class VehicleRentalApp
	{
		static void Main()
		{
			Vehicle[] vehicles =
			{
				new Car("KA01AB1234", 2000, "CAR-INS-001"),
				new Bike("KA02CD5678", 800, "BIKE-INS-002"),
				new Truck("KA03EF9012", 5000, "TRUCK-INS-003")
			};

			RentalCalculator.PrintVehicleCosts(vehicles, 5);
		}
	}
}
