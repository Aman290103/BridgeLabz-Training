/*Problem 3: Bank Account Management
Create a BankAccount class with:
accountNumber (public)
accountHolder (protected)
balance (private)
Implement methods to:
Access and modify balance using public methods.
Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.
*/

using System;

public class BankAccount{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public double GetBalance(){
        return balance;
    }

    public void Deposit(double amount){
        if (amount > 0){
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
        }
        else{
            Console.WriteLine("Invalid deposit amount.");
        }
    }
    public void Withdraw(double amount){
        if (amount > 0 && amount <= balance){
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
        }
        else{
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }
}
public class SavingsAccount : BankAccount{
    public SavingsAccount(string accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance){
    }

    public void displayDetails(){
       Console.WriteLine($"Account Number: {accountNumber}");
       Console.WriteLine($"Account Holder: {accountHolder}");
    }
}

public class Program{
      public static void Main(string[] args){
        BankAccount account = new BankAccount("123456789", "Aman", 1000.0);
        account.Deposit(500.0);
        account.Withdraw(200.0);
        Console.WriteLine($"Current Balance: ${account.GetBalance()}");

        SavingsAccount savingsAccount = new SavingsAccount("987654321", "Shakiya", 2000.0);
        savingsAccount.displayDetails();
    }
}