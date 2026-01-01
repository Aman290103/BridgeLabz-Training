using System;

namespace BridgeLabz;

public class Program{
	static void Main(string[] args){
		Manager manager = new Manager();
		User user = new User();

		Account[] accounts = null;
		int accountCount = 0;

		while (true){
			Console.WriteLine("\n===== LOGIN MENU =====");
			Console.WriteLine("1. Manager Login");
			Console.WriteLine("2. User Login");
			Console.WriteLine("3. Exit");

			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 3) break;

			Console.Write("Enter ID: ");
			string id = Console.ReadLine();

			Console.Write("Enter PIN: ");
			int pin = Convert.ToInt32(Console.ReadLine());

			// MANAGER LOGIN
			if (choice == 1 && id == "manager123" && pin == 9999){
				if (accounts == null){
					manager.SetAccountLimit();
					accounts = new Account[manager.MaxAccounts];
				}

				ManagerMenu(manager, accounts, ref accountCount);
			}
			// USER LOGIN
			else if (choice == 2 && id == "user123" && pin == 1111){
				if (accounts == null || accountCount == 0){
					Console.WriteLine(" No accounts exist yet!");
				}
				else{
					UserMenu(user, accounts, accountCount);
				}
			}
			else{
				Console.WriteLine("Invalid credentials");
			}
		}
	}

	// ============ MANAGER MENU ============
	static void ManagerMenu(Manager manager, Account[] accounts, ref int count){
		while (true){
			Console.WriteLine("\n--- MANAGER MENU ---");
			Console.WriteLine("1. Add Account");
			Console.WriteLine("2. Delete Account");
			Console.WriteLine("3. View All Accounts");
			Console.WriteLine("4. Logout");

			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 4) return;

			if (choice == 1) manager.AddAccount(accounts, ref count);
			else if (choice == 2) manager.DeleteAccount(accounts, ref count);
			else if (choice == 3) manager.ViewAllAccounts(accounts, count);
		}
	}

	// ============ USER MENU ============//
	public static void UserMenu(User user, Account[] accounts, int count){
		Console.Write("Enter Account Number: ");
		string accNo = Console.ReadLine();

		Account account = null;

		for (int i = 0; i < count; i++){
			if (accounts[i].AccountNumber == accNo){
				account = accounts[i];
				break;
			}
		}

		if (account == null){
			Console.WriteLine("Account not found!");
			return;
		}

		while (true){
			Console.WriteLine("\n1. View Balance\n2. Deposit\n3. Withdraw\n4. Logout");
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 4) return;

			if (choice == 1) user.ViewBalance(account);
			else if (choice == 2){
				Console.Write("Amount: ");
				user.Deposit(account, Convert.ToDouble(Console.ReadLine()));
			}
			else if (choice == 3){
				Console.Write("Amount: ");
				user.Withdraw(account, Convert.ToDouble(Console.ReadLine()));
			}
		}
	}
}
