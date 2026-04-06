/* Bank Account Types
Description: Model a banking system with different account types using hierarchical inheritance. BankAccount is the superclass, with SavingsAccount, CheckingAccount, and FixedDepositAccount as subclasses.
Tasks:
Define a base class BankAccount with attributes like AccountNumber and Balance.
Define subclasses SavingsAccount, CheckingAccount, and FixedDepositAccount, each with unique attributes like interestRate for SavingsAccount and WithdrawalLimit for CheckingAccount.
Implement a method DisplayAccountType() in each subclass to specify the account type.
Goal: Explore hierarchical inheritance, demonstrating how each subclass can have unique attributes while inheriting from a shared superclass.
*/

using System;

class BankAccount{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public BankAccount(string accountNumber, double balance){
        this.AccountNumber = accountNumber;
        this.Balance = balance;
      }
}
class SavingsAccount : BankAccount{
    public double InterestRate { get; set; }
    public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance){
        this.InterestRate = interestRate;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Savings Account");
    }
}
class CheckingAccount : BankAccount{
    public double WithdrawalLimit { get; set; }
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance){
        this.WithdrawalLimit = withdrawalLimit;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Checking Account");
    }
}
class FixedDepositAccount : BankAccount{
    public double Term;
    public FixedDepositAccount(string accountNumber, double balance, double term) : base(accountNumber, balance){
        this.Term = term;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Fixed Deposit Account");
    }
}
class BankAccountTypes{
    public static void Main(string[] args){
        SavingsAccount savingsAccount = new SavingsAccount("SA001", 1000, 0.05);
        CheckingAccount checkingAccount = new CheckingAccount("CA001", 2000, 500);
        FixedDepositAccount fixedDepositAccount = new FixedDepositAccount("FDA001", 5000, 12);

        savingsAccount.DisplayAccountType();
        checkingAccount.DisplayAccountType();
        fixedDepositAccount.DisplayAccountType();
    }
}