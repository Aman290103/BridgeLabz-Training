/*
Sample Program 1: Bank Account System
Create a BankAccount class with the following features:
static: 
A static variable bankName shared across all accounts.
A static method GetTotalAccounts() to display the total number of accounts.
this: 
Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
readonly: 
Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
is operator: 
Check if an account object is an instance of the BankAccount class before displaying its details.
*/

using System;

public class BankAccount{
    public static string bankName = "MyBank";
    private static int totalAccounts = 0;
    public readonly int AccountNumber;
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountHolderName, double initialBalance){
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
        AccountNumber = ++totalAccounts;
    }

    public void Deposit(double amount){
        Balance += amount;
    }

    public void Withdraw(double amount){
        if (amount <= Balance){
            Balance -= amount;
        }
        else{
            Console.WriteLine("Insufficient balance.");
        }
    }

    public static void GetTotalAccounts(){
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }

    public void DisplayAccountDetails(){
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance}");
    }
}
public class Program{
    public static void Main(string[] args){
        BankAccount account1 = new BankAccount("John Doe", 1000);
        BankAccount account2 = new BankAccount("Jane Smith", 2000);

        account1.Deposit(500);
        account2.Withdraw(1000);

        Console.WriteLine("Account 1 Details:");
        account1.DisplayAccountDetails();

        Console.WriteLine("\nAccount 2 Details:");
        account2.DisplayAccountDetails();

        Console.WriteLine($"\nBank Name: {BankAccount.bankName}");
        BankAccount.GetTotalAccounts();
    }
}
