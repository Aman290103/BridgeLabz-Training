using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Future_Logistics
{
    public class TimberTransport : GoodsTransport
    {
        private float timberLength {  get; set; }
        private float timberRadius { get; set; }

        private string timberType { get; set; }

        private float timberPrice { get; set; }

        public TimberTransport(string id, string date, int rating, float length, float radius, string type, float price) : base(id, date, rating)
        {
            timberLength = length;  
            timberRadius = radius;
            timberType = type;
            timberPrice = price;
            
        }

        public override string vehicleSelection() 
        {
            double area = 2 * 3.14 * timberRadius * timberLength;

            if(area < 250) 
            {
                return "Truck";
            }
            else if(area >= 250 && area <= 400) 
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
            float volume = 3.147f * timberRadius * timberRadius * timberLength;

            float rate = 0;
            if (timberType.Equals("Premium", StringComparison.OrdinalIgnoreCase))
            {
                rate = 0.25f;
            }
            else if (timberType.Equals("NonPremium", StringComparison.OrdinalIgnoreCase))
            {
                rate = 0.15f;
            }

                float price = volume * timberPrice * rate;

                float tax = 0.3f * price;

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
                else if (transportRating == 1 || transportRating == 2)
                {
                    discount = 0;
                }

                float totalCharge = ((price) + vehiclePrice + tax) - discount;
                return totalCharge;
            }
        }

    
}
