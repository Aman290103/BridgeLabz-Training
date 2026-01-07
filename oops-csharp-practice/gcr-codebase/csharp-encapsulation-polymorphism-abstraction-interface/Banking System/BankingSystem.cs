using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Banking_System
{
		class BankingSystem
		{
			public static void Main()
			{
				BankAccount acc1 = new SavingsAccount(101, "Rahul", 50000);
				BankAccount acc2 = new CurrentAccount(102, "Anita", 100000);

				ProcessAccount(acc1);
				ProcessAccount(acc2);
			}

			static void ProcessAccount(BankAccount account)
			{
				double interest = account.CalculateInterest();

				Console.WriteLine("Account Holder: " + account.HolderName);
				Console.WriteLine("Account Number: " + account.AccountNumber);
				Console.WriteLine("Balance: " + account.Balance);
				Console.WriteLine("Interest: " + interest);

				if (account is ILoanable loanable)
				{
					loanable.ApplyForLoan();
					Console.WriteLine("Loan Eligibility: " + loanable.CalculateLoanEligibility());
				}

				Console.WriteLine("-----------------------------------");
			}
		}
	}


