using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.ChargeMaster
{
    public class CarChargingProcessor : ChargingSessionProcessor
    {
        public CarChargingProcessor(int start, int end, int duration, string mode) : base(start, end, duration, mode)
        { }

        public override void validateSession()
        {
            if (startBattery < 10 || startBattery > 90)
            {
                throw new InvalidChargingDataException("Invalid start Battery");
            }
            if(endBattery <startBattery || endBattery > 100)
            {
                throw new InvalidChargingDataException("Invalid End Batter");

            }
            if(duration <10 || duration > 180)
            {
                throw new InvalidChargingDataException("Invalid charging duration");
            }

            if(!(mode.Equals("Normal",StringComparison.OrdinalIgnoreCase) || (mode.Equals("Fast Fast", StringComparison.OrdinalIgnoreCase))))
            {
                throw new InvalidChargingDataException("Invalid charging Mode");
            }
        }

        public override double calculateChargingCost()
        {
            double rate = 0;

            if (mode.Equals("Normal", StringComparison.OrdinalIgnoreCase))
            {
                rate = 10;
            } else if(mode.Equals("Fast Fast", StringComparison.OrdinalIgnoreCase))
            {
                rate = 15;
            }

            double charge = rate * duration;

            if(endBattery == 100)
            {
                charge += 75;
            }
           
            return charge;

        }
    }
}
