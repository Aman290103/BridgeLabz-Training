using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ParcelTracker___Delivery_Chain_Management
{
    public class ParcelTrackerMain
    {
        public static void Main(string[] args)
        {
            IParcelTracker parcelTracker = new ParcelTrackerUtility();
            parcelTracker.AddStage("Order Placed");
            parcelTracker.AddStage("Dispatched");
            parcelTracker.AddStage("In Transit");
            parcelTracker.AddStage("Out for Delivery");
            parcelTracker.AddStage("Delivered");

			// Add custom checkpoint
			parcelTracker.AddCheckpointAfter("In Transit", "Customs Check");

			// Track parcel forward
			parcelTracker.TrackForward();
            //Handle missing Parcel scenario
            parcelTracker.HandleMissingParcel();
		}
	}
}
