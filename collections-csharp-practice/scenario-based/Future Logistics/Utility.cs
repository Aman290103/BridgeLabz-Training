using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Future_Logistics
{
    public class Utility
    {
        public GoodsTransport parseDetails(string input) 
        {
            string[] data = input.Split(':');

            string transportId = data[0];

            if (!validateTransport(transportId)) 
            {
                return null;
            }

            string transportDate = data[1];
            int transporRating = int.Parse(data[2]);
            string transportType = data[3];

            if (transportType.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
     

                float brickSize = float.Parse(data[4]);
                int brickQuantity = int.Parse(data[5]);
                float brickPrice = float.Parse(data[6]);

                return new BrickTransport
                    (
						transportId,
				        transportDate,
				        transporRating,
				        brickSize,
				        brickQuantity,
				        brickPrice

					);
            }
            else if (transportType.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase))
            {
                float timberLength = float.Parse(data[4]);
                float timberRadius = float.Parse(data[5]);
                string timberType = data[6];
                float timberPrice = float.Parse(data[7]);

                return new TimberTransport
                    (
                        transportId,
                        transportDate,
                        transporRating,
                        timberLength,
                        timberRadius,
                        timberType,
                        timberPrice

                    );

            }
            return null;
        }

        public bool validateTransport(string transportId) 
        {
            string pattern = @"^RTS[0-9]{3}[A-Z]$";

            if (!Regex.IsMatch(transportId, pattern)) 
            {
                Console.WriteLine($"Transport Id {transportId} is Invalid");
                Console.WriteLine("Please provide valid record");
                return false;
            }

            return true;
        }

        public String findObjectType(GoodsTransport goodsTransport) 
        {
            if(goodsTransport is TimberTransport)
            {
                return "TimberTransport";
            }
            else if(goodsTransport is BrickTransport) 
            {
                return "BrickTransport";
            }

            return "";
        }

    }
}
