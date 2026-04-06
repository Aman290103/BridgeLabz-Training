using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Ride_Hailing_Application
{
		public abstract class Vehicle
		{
			private int _vehicleId;
			private string _driverName;
			private double _ratePerKm;

			protected Vehicle(int vehicleId, string driverName, double ratePerKm)
			{
				_vehicleId = vehicleId;
				_driverName = driverName;
				_ratePerKm = ratePerKm;
			}

			public int VehicleId
			{
				get { return _vehicleId; }
				protected set { _vehicleId = value; }
			}

			public string DriverName
			{
				get { return _driverName; }
				protected set { _driverName = value; }
			}

			public double RatePerKm
			{
				get { return _ratePerKm; }
				protected set { _ratePerKm = value; }
			}

			public string GetVehicleDetails()
			{
				return $"Vehicle ID: {_vehicleId}, Driver: {_driverName}, Rate/Km: {_ratePerKm}";
			}

			public abstract double CalculateFare(double distance);
		}
	}


