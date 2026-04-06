using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
		public class Bike : Vehicle, IInsurable
		{
			private string _insurancePolicyNumber;

			public Bike(string number, double rate, string policyNumber)
				: base(number, "Bike", rate)
			{
				_insurancePolicyNumber = policyNumber;
			}

			public override double CalculateRentalCost(int days)
			{
				return (RentalRate * days) * 0.9; // 10% discount
			}

			public double CalculateInsurance()
			{
				return 200;
			}

			public string GetInsuranceDetails()
			{
				return "Bike Insurance Policy: " + _insurancePolicyNumber;
			}
	}
}


