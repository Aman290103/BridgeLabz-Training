using System;
using System.Diagnostics;

public class MenuManager{
	private string[] menuItems ={
		"Burger",
		"Pizza",
		"Sandwich",
		"Pasta",
		"Salad",
		"Fried Rice",
		"Noodles",
		"Soup",
		"Coffee",
		"Ice Cream"
	};

	private double[] prices ={
		80, 120, 60, 100, 50,
		90, 85, 70, 40, 60
	};
	public void DisplayMenu(){
		Console.WriteLine("\n----- Cafeteria Menu -----");
		for (int i = 0; i < menuItems.Length; i++){
			Console.WriteLine($"{i+1}\t{menuItems[i]}\t\t\t${prices[i]}");
		}
	}

	public string GetItemByIndex(int index){
		if (index >= 0 && index < menuItems.Length){
			return menuItems[index];
		}
		return null;
	}

	public double GetPriceByIndex(int index)
	{
		if (index >= 0 && index < prices.Length)
			return prices[index];
		return 0;
	}
}
