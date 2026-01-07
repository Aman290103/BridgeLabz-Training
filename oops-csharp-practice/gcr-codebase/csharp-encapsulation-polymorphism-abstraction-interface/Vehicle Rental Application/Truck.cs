using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
		public class Truck : Vehicle, IInsurable
		{
			private string _insurancePolicyNumber;

			public Truck(string number, double rate, string policyNumber)
				: base(number, "Truck", rate)
			{
				_insurancePolicyNumber = policyNumber;
			}

			public override double CalculateRentalCost(int days)
			{
				return (RentalRate * days) + 1000; // additional load charge
			}

			public double CalculateInsurance()
			{
				return 1000;
			}

			public string GetInsuranceDetails()
			{
				return "Truck Insurance Policy: " + _insurancePolicyNumber;
			}
		}
	}


