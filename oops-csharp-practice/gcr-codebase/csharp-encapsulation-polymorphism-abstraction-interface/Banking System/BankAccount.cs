using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Banking_System
{
		public abstract class BankAccount
		{
			private int _accountNumber;
			private string _holderName;
			private double _balance;

			protected BankAccount(int accountNumber, string holderName, double balance)
			{
				_accountNumber = accountNumber;
				_holderName = holderName;
				_balance = balance;
			}

			public int AccountNumber
			{
				get { return _accountNumber; }
				protected set { _accountNumber = value; }
			}

			public string HolderName
			{
				get { return _holderName; }
				protected set { _holderName = value; }
			}

			public double Balance
			{
				get { return _balance; }
				protected set
				{
					if (value >= 0)
						_balance = value;
				}
			}

			public void Deposit(double amount)
			{
				if (amount > 0)
					Balance += amount;
			}

			public virtual void Withdraw(double amount)
			{
				if (amount > 0 && amount <= Balance)
					Balance -= amount;
			}

			public abstract double CalculateInterest();
		}
	}


