using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Banking_System
{
		public class CurrentAccount : BankAccount, ILoanable
		{
			public CurrentAccount(int accNo, string name, double balance)
				: base(accNo, name, balance) { }

			public override double CalculateInterest()
			{
				return Balance * 0.02; // 2% interest
			}

			public override void Withdraw(double amount)
			{
				Balance -= amount; // Overdraft allowed
			}

			public void ApplyForLoan()
			{
				Console.WriteLine("Loan applied for Current Account.");
			}

			public double CalculateLoanEligibility()
			{
				return Balance * 3; // Eligible up to 3x balance
			}
		}
	}


