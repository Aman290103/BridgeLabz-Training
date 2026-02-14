using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Future_Logistics
{
    public class BrickTransport : GoodsTransport
    {
        private float brickSize { get; set; }
        private int brickQuantity { get; set; }
        private float brickPrice { get; set; }

        public BrickTransport(string id, string date, int rating, float size, int quantity, float price)
            : base(id, date, rating)
        { 
            brickPrice = price;
            brickSize = size;
            brickQuantity = quantity;
        }

        public override string vehicleSelection()
        {
            if (brickQuantity < 300)
            {
                return "Truck";
            }
            else if(brickQuantity>=300 && brickQuantity<=500)
            {
                return "Lorry";
            }
            else
            {
                return "MonsterLorry";
            }    
        }
		public override float calculateTotalCharge() 
        {
            float price = brickPrice*brickQuantity;

            float tax = price * 0.3f;

            float vehiclePrice = 0;
            string vehicle = vehicleSelection();

            if (vehicle.Equals("Truck", StringComparison.OrdinalIgnoreCase))
            {
                vehiclePrice = 1000;
            }
            else if (vehicle.Equals("Lorry", StringComparison.OrdinalIgnoreCase))
            {
                vehiclePrice = 1700;
            }
            else if (vehicle.Equals("MonsterLorry", StringComparison.OrdinalIgnoreCase)) 
            {
                vehiclePrice = 3000;
            }

            float discount = 0;

            if (transportRating == 5)
            {
                discount = price * 0.2f;
            }
            else if (transportRating == 3 || transportRating == 4) 
            {
                discount = price * 0.1f;
            }
            else if(transportRating ==1 || transportRating == 2) 
            {
                discount = 0;
            }

            float totalCharge = ((price) + vehiclePrice + tax )- discount;
            return totalCharge;
        }


	}
}
