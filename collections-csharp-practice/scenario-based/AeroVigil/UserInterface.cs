using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AeroVigil
{
	public class UserInterface
	{
		public void start()
		{
			IFlightUtil util = new FlightUtil();
			int choice;

			do
			{
				Console.WriteLine("/nAero Vigil");
				Console.WriteLine("1.Enter Flight Details");
				Console.WriteLine("2.Exit");
				Console.WriteLine("Enter your choice");
				choice = Convert.ToInt32(Console.ReadLine());

				if (choice == 1)
				{
					try
					{
						Console.WriteLine("Enter Flight Details");
						string flightDetails = Console.ReadLine();
						string[] data = flightDetails.Split(':');
						string flightNumber = data[0];
						string flightName = data[1];
						int passengerCount = Convert.ToInt32(data[2]);
						double fuelLevel = Convert.ToDouble(data[3]);

						util.validateFlightNumber(flightNumber);
						util.validateFlightName(flightName);
						util.validatePassengerCount(passengerCount, flightName);
						double fuel = util.calculateFuelToFilltank(flightName, fuelLevel);
						Console.WriteLine($"Fuel Required to fill the tank is : {fuel}");
					}
					catch (InvalidFlightException ex)
					{
						Console.WriteLine(ex.Message);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Invalid Input Format");
					}
				}
				
			} while (choice != 2);

		}
	}
}
