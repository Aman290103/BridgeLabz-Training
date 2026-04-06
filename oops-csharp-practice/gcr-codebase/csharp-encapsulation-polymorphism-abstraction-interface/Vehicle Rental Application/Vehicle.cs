using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
		public abstract class Vehicle
		{
			private string _vehicleNumber;
			private string _type;
			private double _rentalRate;

			protected Vehicle(string vehicleNumber, string type, double rentalRate)
			{
				_vehicleNumber = vehicleNumber;
				_type = type;
				_rentalRate = rentalRate;
			}

			public string VehicleNumber
			{
				get { return _vehicleNumber; }
				protected set { _vehicleNumber = value; }
			}

			public string Type
			{
				get { return _type; }
				protected set { _type = value; }
			}

			public double RentalRate
			{
				get { return _rentalRate; }
				protected set
				{
					if (value > 0)
						_rentalRate = value;
				}
			}

			public abstract double CalculateRentalCost(int days);
	}
}



