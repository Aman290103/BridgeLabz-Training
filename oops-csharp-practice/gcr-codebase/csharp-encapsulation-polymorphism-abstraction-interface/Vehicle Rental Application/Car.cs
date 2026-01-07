using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
		public class Car : Vehicle, IInsurable
		{
			private string _insurancePolicyNumber;

			public Car(string number, double rate, string policyNumber)
				: base(number, "Car", rate)
			{
				_insurancePolicyNumber = policyNumber;
			}

			public override double CalculateRentalCost(int days)
			{
				return RentalRate * days;
			}

			public double CalculateInsurance()
			{
				return 500;
			}

			public string GetInsuranceDetails()
			{
				return "Car Insurance Policy: " + _insurancePolicyNumber;
			}
	}
}


