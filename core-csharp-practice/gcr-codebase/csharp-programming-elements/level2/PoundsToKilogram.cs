/*12. Create a program to convert weight in pounds to kilograms.
Hint:
1 pound = 2.2 kg
I/P => weight (in pounds)
O/P => The weight of the person in pounds is ___ and in kg is ___*/

using System;

public class PoundsToKilogram{
    public static void Main(string[] args){
        Console.Write("Enter the weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kilograms = pounds / 2.2;

        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kilograms}");
    }
}

