using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.ChargeMaster
{
    public class ChargingConsole
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your Vehicle Type");
                string vehicleType = Console.ReadLine();

                Console.WriteLine("Enter the start Battery");

                int startBattery = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the end battery");

                int endBattery = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Charging duration");

                int duration = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the charging mode");

                string mode = Console.ReadLine();

                ChargingSessionProcessor processor;

                if (vehicleType.Equals("Scooter", StringComparison.OrdinalIgnoreCase)){
                    processor = new ScooterChargingProcessor(startBattery, endBattery, duration, mode);
                } else if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
                {
                    processor = new CarChargingProcessor(startBattery, endBattery, duration, mode);
                }

                else
                {
                    Console.WriteLine("Unsuported Vehicle");
                    return;
                }

                double charge = processor.processSession(startBattery, endBattery, duration, mode);

                Console.WriteLine($"vehicle Type : {vehicleType}");

                Console.WriteLine($"Charging charges : {charge}");

                

            }
			catch (InvalidChargingDataException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid numeric input");
			}
		}
    }
}
