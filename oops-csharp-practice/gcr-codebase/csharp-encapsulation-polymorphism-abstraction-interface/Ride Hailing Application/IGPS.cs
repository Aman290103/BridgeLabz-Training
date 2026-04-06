using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Ride_Hailing_Application
{
	public interface IGPS
	{
		string GetCurrentLocation();
		void UpdateLocation(string location);
	}
}
