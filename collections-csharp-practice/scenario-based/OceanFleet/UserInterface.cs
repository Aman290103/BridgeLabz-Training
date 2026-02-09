using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OceanFleet
{
    public class UserInterface
    {
        
        public static void Main(string[] args) 
        {
            VesselUtil util = new VesselUtil();

            Console.WriteLine("Enter the number of vessels to be added :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vessel details");

            for (int i = 0; i < n; i++)
            {
                string details = Console.ReadLine();

                string[] parts = details.Split(':');

                string VesselId = parts[0];
                string VesselName = parts[1];
                double AverageSpeed = Convert.ToDouble(parts[2]);
                string VesselType = parts[3];

                Vessel vessel = new Vessel
                { 
                    vesselId = VesselId,
                    vesselName = VesselName,
                    averageSpeed = AverageSpeed,
                    vesselType = VesselType

                };

                util.addVesselPerformance(vessel);

            }
            Console.WriteLine("Enter the vessel Id to check speed");

            string searchId = Console.ReadLine();

            Vessel found = util.getVesselById(searchId);

            if (found != null) 
            {
                Console.WriteLine($"{found.vesselId} | {found.vesselName} | {found.vesselType} | {found.averageSpeed} knots");
            }
            else
            {
                Console.WriteLine($"Vessel Id {found.vesselId} not found.");
            }


            Console.WriteLine("High performance vessels are");
            List<Vessel> topVessels = util.gettingHighPerformanceVessel();

            foreach (var v in topVessels) 
            {
                Console.WriteLine($"{v.vesselId} | {v.vesselName} | {v.vesselType} | {v.averageSpeed} knots");
            }
        }

        

    }

}
