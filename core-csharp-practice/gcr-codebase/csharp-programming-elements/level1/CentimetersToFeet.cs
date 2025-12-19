/*10. Write a program that takes your height in centimeters and converts it into feet and
inches
Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
I/P => height
O/P => Your Height in cm is ___ while in feet is ___ and inches is ___*/

using System;

public class CentimetersToFeet{

    public static void Main(string[] args)
    {
        Console.Write("Enter your height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        double heightInFeet = heightInCm / 30.48;
        double heightInInches = heightInCm / 2.54;

        Console.WriteLine($"Your height in cm is {heightInCm:F2} while in feet is {heightInFeet:F2} and inches is {heightInInches:F2}");
    }
}
