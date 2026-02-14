using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Future_Logistics
{
    public abstract class GoodsTransport
    {
		public string transportId { get; set; }
		public string transportDate { get; set; }
		public int transportRating { get; set; }

        public GoodsTransport(string transportid, string transportDate, int transportRating)
        {
            this.transportId = transportid;
            this.transportDate = transportDate;
            this.transportRating = transportRating;
        }

        public abstract string vehicleSelection();

        public abstract float calculateTotalCharge();

    }
}
