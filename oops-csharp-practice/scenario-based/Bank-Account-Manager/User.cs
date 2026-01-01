using System;

public class User
{
    public string UserName;

    public void ViewBalance(Account account)
    {
        Console.WriteLine("User Balance: " + account.Balance);
    }

    public void Deposit(Account account, double amount)
    {
        if (amount > 0)
        {
            account.Balance += amount;
            Console.WriteLine("User Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(Account account, double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount");
        }
        else if (amount > account.Balance)
        {
            Console.WriteLine("Transaction Failed: Insufficient Balance");
        }
        else
        {
            account.Balance -= amount;
            Console.WriteLine("User Withdrawn: " + amount);
        }
    }
}
