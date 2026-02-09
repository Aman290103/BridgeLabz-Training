using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OceanFleet
{
    public class VesselUtil
    {
		private List<Vessel> vesselList { get; set; } = new List<Vessel>();


		public void addVesselPerformance(Vessel vessel)
		{
			vesselList.Add(vessel);
		}

		public Vessel getVesselById(String vesselId) 
		{
			foreach(Vessel v in vesselList) 
			{
				if (string.Equals(v.vesselId, vesselId))
				{
					return v;
				}
			}
			return null;
		}

		public List<Vessel> gettingHighPerformanceVessel() 
		{
			List<Vessel> result = new List<Vessel>();

			if (vesselList.Count == 0 || vesselList.Count == null) 
			{
				return result;
			}

			double maxSpeed = vesselList[0].averageSpeed;

			foreach (Vessel v in vesselList) 
			{
				if(v.averageSpeed > maxSpeed)
				{
					maxSpeed = v.averageSpeed;
				}

			}

			foreach (Vessel v in result) 
			{
				result.Add(v);
			}
			return result;
		}



	}
}
