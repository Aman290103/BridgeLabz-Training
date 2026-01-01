using System;

public class Bank{
	public string BankName;
	public string BranchName;
	public string IFSCCode;

	public void DisplayBankDetails(){
		Console.WriteLine("Bank Name   : " + BankName);
		Console.WriteLine("Branch Name : " + BranchName);
		Console.WriteLine("IFSC Code   : " + IFSCCode);
	}
}
