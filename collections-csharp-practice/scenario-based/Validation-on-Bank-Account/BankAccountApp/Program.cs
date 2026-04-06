using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_on_Bank_Account
{
    public class Program
    {
        public double Balance { get; set; }
        public Program(double balance)
        {
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Deposit amount cannot be negative.");

			}
            Balance += amount;
            Console.WriteLine($"{amount} rupees Deposited in the Account");
        }

        public void Withdraw(double amount) 
        {
            if (amount > Balance) 
            {
                throw new Exception("Insufficient Funds.");
            }
            Balance -= amount;
            Console.WriteLine($"{amount} rupees Withdraw from the Account ");
        }
    }
}
