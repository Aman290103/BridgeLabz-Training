namespace BridgeLabz;

public class Account{
	public string AccountNumber;
	public string AccountHolderName;
	public string FatherName;
	public double Balance;

	public void DisplayAccountDetails(){
		Console.WriteLine("Account No  : " + AccountNumber);
		Console.WriteLine("Name        : " + AccountHolderName);
		Console.WriteLine("Father Name : " + FatherName);
		Console.WriteLine("Balance     : " + Balance);
	}
}
