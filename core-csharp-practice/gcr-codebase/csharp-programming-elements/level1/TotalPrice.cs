/*15. Write a program to input the unit price of an item and the quantity to be bought. Then,
calculate the total price.
Hint: NA
I/P => unitPrice, quantity
O/P => The total purchase price is INR ___ if the quantity ___ and unit price is INR ___*/

using System;

public class totalPrice
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and unit price is INR {unitPrice}");
    }
}
