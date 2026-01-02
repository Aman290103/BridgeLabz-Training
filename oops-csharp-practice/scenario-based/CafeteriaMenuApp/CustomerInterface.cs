using System;

public class CustomerInterface{
	private MenuManager menuManager;
	private OrderManager orderManager;

	public CustomerInterface(){
		menuManager = new MenuManager();
		orderManager = new OrderManager(menuManager);
	}

	public void Start(){
		int choice = 0;
		do{
			Console.WriteLine("\n===== Cafeteria System =====");
			Console.WriteLine("1. Display Menu");
			Console.WriteLine("2. Add Item");
			Console.WriteLine("3. Generate Bill");
			Console.WriteLine("4. Exit");
			Console.Write("Enter choice: ");

			try{
				choice = Convert.ToInt32(Console.ReadLine());
			}
			catch{
				Console.WriteLine("Invalid input.");
				continue;
			}

			switch (choice){
				case 1:
					menuManager.DisplayMenu();
					break;

				case 2:
					menuManager.DisplayMenu();

					Console.Write("Enter item index: ");
					int index = Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter quantity: ");
					int qty = Convert.ToInt32(Console.ReadLine());
					orderManager.AddOrder(index, qty);
					break;
				case 3:
					orderManager.GenerateBill();
					break;
				case 4:
					Console.WriteLine("Thank you! Visit again 😊");
					break;
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		} while (choice != 4);
	}
}
