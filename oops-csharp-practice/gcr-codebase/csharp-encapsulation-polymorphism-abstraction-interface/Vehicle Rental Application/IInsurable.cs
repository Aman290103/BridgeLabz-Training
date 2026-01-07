using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Vehicle_Rental_Application
{
	public interface IInsurable
	{
		double CalculateInsurance();
		string GetInsuranceDetails();
	}
}
