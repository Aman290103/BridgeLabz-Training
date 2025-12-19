/*9. Write a new program similar to the program # 6 but take user input for Student Fee and
University Discount
Hint:
Create a variable named fee and take user input for fee.
Create another variable discountPercent and take user input.
Compute the discount and assign it to the discount variable.
Compute and print the fee you have to pay by subtracting the discount from the fee.
I/P => fee, discountPrecent
O/P => The discount amount is INR ___ and final discounted fee is INR ___*/

using System;

public class UniversityDiscount
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the student fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the university discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = fee * (discountPercent / 100);
        double discountedFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
}
