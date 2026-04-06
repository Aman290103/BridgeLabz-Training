using System;

class OrderManager{
	private MenuManager menuManager;

	private string[] orderedItems = new string[20];
	private int[] quantities = new int[20];
	private double[] prices = new double[20];

	private int orderCount = 0;
	public OrderManager(MenuManager menuManager){
		this.menuManager = menuManager;
	}

	public void AddOrder(int index, int quantity){
		string item = menuManager.GetItemByIndex(index);
		double price = menuManager.GetPriceByIndex(index);

		if (item != null && quantity > 0 && orderCount < 20){
			orderedItems[orderCount] = item;
			quantities[orderCount] = quantity;
			prices[orderCount] = price;
			orderCount++;

			Console.WriteLine("Item added successfully!");
		}
		else{
			Console.WriteLine("Invalid item or quantity.");
		}
	}

	public void GenerateBill(){
		if (orderCount == 0){
			Console.WriteLine("No items ordered.");
			return;
		}
		double total = 0;
		Console.WriteLine("\n----- BILL -----");
		Console.WriteLine("Item\tQty\tPrice\tTotal");

		for (int i = 0; i < orderCount; i++){
			double itemTotal = prices[i] * quantities[i];
			total += itemTotal;
			Console.WriteLine($"{orderedItems[i]}\t{quantities[i]}\t${prices[i]}\t${itemTotal}");
		}
		Console.WriteLine("---------------------------");
		Console.WriteLine("Grand Total: $" + total);
	}
}
