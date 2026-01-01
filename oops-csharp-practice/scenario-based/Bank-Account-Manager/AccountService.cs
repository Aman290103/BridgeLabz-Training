using System;
using System.Security.Principal;

public class AccountService{
	public void Deposit(Account account, double amount){
		if (amount > 0){
			account.Balance += amount;
			Console.WriteLine("Deposit Successful: " + amount);
		}
		else{
			Console.WriteLine("Invalid deposit amount");
		}
	}

	public void Withdraw(Account account, double amount){
		if (amount <= 0){
			Console.WriteLine("Invalid withdrawal amount");
		}
		else if (amount > account.Balance){
			Console.WriteLine("Withdrawal Failed: Insufficient Balance");
		}
		else{
			account.Balance -= amount;
			Console.WriteLine("Withdrawal Successful: " + amount);
		}
	}

	public void CheckBalance(Account account){
		Console.WriteLine("Current Balance: " + account.Balance);
	}
}
