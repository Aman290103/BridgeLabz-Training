using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OceanFleet
{
    public class Vessel
    {
		public string vesselId {  get; set; }
		public string vesselName {  get; set; }
		public double averageSpeed { get; set; }
		public string vesselType { get; set; }

		public Vessel(string vesselid , string vesselname, double averagespeed, string vesseltype ) 
		{
			vesselId = vesselid;
			vesselName = vesselname;
			averageSpeed = averagespeed;
			vesselType = vesseltype;
		}
		public Vessel() { }

	}
}
