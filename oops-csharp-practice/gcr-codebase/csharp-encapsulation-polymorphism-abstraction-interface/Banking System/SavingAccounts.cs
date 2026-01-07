using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Banking_System
{
		public class SavingsAccount : BankAccount, ILoanable
		{
			public SavingsAccount(int accNo, string name, double balance)
				: base(accNo, name, balance) { }

			public override double CalculateInterest()
			{
				return Balance * 0.04; // 4% interest
			}

			public void ApplyForLoan()
			{
				Console.WriteLine("Loan applied for Savings Account.");
			}

			public double CalculateLoanEligibility()
			{
				return Balance * 5; // Eligible up to 5x balance
			}
		}
	}


