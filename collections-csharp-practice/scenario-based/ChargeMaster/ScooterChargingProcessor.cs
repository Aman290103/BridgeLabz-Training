using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.ChargeMaster
{
    public class ScooterChargingProcessor : ChargingSessionProcessor
    {
        public ScooterChargingProcessor(int start, int end, int duration, string mode) : base(start, end, duration, mode)
        {
        }

        public override void validateSession()
        {
            if(startBattery<0 || startBattery > 80)
            {
                throw new InvalidChargingDataException("Start Battery must be in between 0 to 80");
            }   

            if(endBattery<startBattery || endBattery > 100)
            {
                throw new InvalidChargingDataException("End Battery must be in between start battery and 100");
            }

            if (duration <= 0)
            {
                throw new InvalidChargingDataException("Invalid Charging duration");
            }

            if(!(mode.Equals("Normal",StringComparison.OrdinalIgnoreCase) || (mode.Equals("Fast", StringComparison.OrdinalIgnoreCase))))
            {
                throw new InvalidChargingDataException("Invalid Charging Mode");
            }
        }

        public override double calculateChargingCost()
        {
            double rate = 0;
            if (mode.Equals("Fast", StringComparison.OrdinalIgnoreCase))
            {
                rate = 8;
            } else if (mode.Equals("Normal", StringComparison.OrdinalIgnoreCase))
            {
                rate = 5;
            }

            double charge = rate * duration;

            if (startBattery < 20)
            {
                charge += 50;
            }

            return charge;
        }
    }
}
