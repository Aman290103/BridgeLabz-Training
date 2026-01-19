using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ParcelTracker___Delivery_Chain_Management
{
    public interface IParcelTracker
    {
        void AddStage(string stageName);

		void AddCheckpointAfter(string existingStage, string newStage);
		void TrackForward();
		void HandleMissingParcel();

	}
}
