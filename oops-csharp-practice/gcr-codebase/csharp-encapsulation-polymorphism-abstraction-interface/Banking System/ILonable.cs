using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Banking_System
{
	public interface ILoanable
	{
		void ApplyForLoan();
		double CalculateLoanEligibility();
	}
}
