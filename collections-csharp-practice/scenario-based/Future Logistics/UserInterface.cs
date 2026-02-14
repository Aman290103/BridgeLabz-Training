using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Future_Logistics
{
    public class UserInterface
    {
        public static void Main(string[] args) 
        {
            Utility utility = new Utility();

            Console.WriteLine("Enter the Goods Transport details");

            string input = Console.ReadLine();

            GoodsTransport gt  = utility.parseDetails(input);

            if (gt == null) { return; }

            string type = utility.findObjectType(gt);


            float totalCharge = gt.calculateTotalCharge();

			Console.WriteLine("Transport Id: " + gt.transportId);
			Console.WriteLine("Transport Date: " + gt.transportDate);
			Console.WriteLine("Transport Rating: " + gt.transportRating);
			Console.WriteLine("Transport Type: " + type);
			Console.WriteLine("Vehicle Type: " + gt.vehicleSelection());
			Console.WriteLine("Total Charge: " + totalCharge);
		}
    }
}
