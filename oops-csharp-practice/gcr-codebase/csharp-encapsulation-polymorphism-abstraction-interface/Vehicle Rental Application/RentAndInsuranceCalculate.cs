using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
		public class RentalCalculator
		{
			public static void PrintVehicleCosts(List<Vehicle> vehicles, int days)
			{
				foreach (Vehicle vehicle in vehicles)
				{
					double rentalCost = vehicle.CalculateRentalCost(days);
					double insuranceCost = 0;

					if (vehicle is IInsurable insurable)
					{
						insuranceCost = insurable.CalculateInsurance();
					}

					Console.WriteLine($"Vehicle Type: {vehicle.Type}");
					Console.WriteLine($"Vehicle Number: {vehicle.VehicleNumber}");
					Console.WriteLine($"Rental Cost for {days} days: {rentalCost}");
					Console.WriteLine($"Insurance Cost: {insuranceCost}");
					Console.WriteLine($"Total Cost: {rentalCost + insuranceCost}");
					Console.WriteLine("-------------------------------------");
				}
			}
		}
	}


