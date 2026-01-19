using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ParcelTracker___Delivery_Chain_Management
{
    public class ParcelStage
    {
        public string StageName { get; private set; }
        public ParcelStage Next { get; set; }

        public ParcelStage(string stageName)
        {
            StageName = stageName;
            Next = null;
		}
	}
}
