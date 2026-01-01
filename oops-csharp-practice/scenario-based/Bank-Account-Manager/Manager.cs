namespace BridgeLabz;

public class Manager{
	public string ManagerName;
	public int MaxAccounts;

	public void SetAccountLimit(){
		Console.Write("Enter maximum number of accounts manager can manage: ");
		MaxAccounts = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Account limit set to: " + MaxAccounts);
	}

	public void AddAccount(Account[] accounts, ref int count){
		if (count >= MaxAccounts){
			Console.WriteLine("❌ Cannot add account. Manager limit reached!");
			return;
		}

		Account acc = new Account();

		Console.Write("Enter Account Number: ");
		acc.AccountNumber = Console.ReadLine();

		Console.Write("Enter Account Holder Name: ");
		acc.AccountHolderName = Console.ReadLine();

		Console.Write("Enter Father Name: ");
		acc.FatherName = Console.ReadLine();

		Console.Write("Enter Initial Balance: ");
		acc.Balance = Convert.ToDouble(Console.ReadLine());

		accounts[count] = acc;
		count++;

		Console.WriteLine("✅ Account added successfully!");
	}

	public void DeleteAccount(Account[] accounts, ref int count)
	{
		Console.Write("Enter Account Number to delete: ");
		string accNo = Console.ReadLine();

		int index = -1;

		for (int i = 0; i < count; i++)
		{
			if (accounts[i].AccountNumber == accNo)
			{
				index = i;
				break;
			}
		}

		if (index == -1)
		{
			Console.WriteLine("❌ Account not found!");
			return;
		}

		for (int i = index; i < count - 1; i++)
		{
			accounts[i] = accounts[i + 1];
		}

		count--;
		Console.WriteLine("✅ Account deleted successfully!");
	}

	public void ViewAllAccounts(Account[] accounts, int count)
	{
		for (int i = 0; i < count; i++)
		{
			accounts[i].DisplayAccountDetails();
			Console.WriteLine("------------------");
		}
	}
}
