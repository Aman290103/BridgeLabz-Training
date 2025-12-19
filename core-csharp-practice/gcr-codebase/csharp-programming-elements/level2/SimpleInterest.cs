/*11. Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
Hint:
Simple Interest = (Principal * Rate * Time) / 100
I/P => principal, rate, time
O/P => The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___*/

using System;

public class SimpleInterest
{
    public static void Main()
    {
        Console.WriteLine("Enter the Principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}

