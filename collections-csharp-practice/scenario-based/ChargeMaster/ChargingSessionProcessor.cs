using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.ChargeMaster
{
    public abstract class ChargingSessionProcessor
    {
        protected int startBattery {  get; set; }
        protected int endBattery { get; set; }
        protected int duration {  get; set; }
        protected string mode { get; set; }

        public ChargingSessionProcessor(int start, int end , int duration,string mode)
        {
            this.startBattery = start;
            this.endBattery = end;
            this.duration = duration;
            this.mode = mode;   
        }

        public abstract void validateSession();
        public abstract double calculateChargingCost();

        public double processSession(int start , int end , int duration , string mode)
        {
            validateSession();
            return calculateChargingCost();
        }


	}
}
