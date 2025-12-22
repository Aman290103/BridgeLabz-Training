/*Write a program to check if the first is the smallest of the 3 numbers.
I/P => number1, number2, number3
O/P => Is the first number the smallest? ____*/

using System;

public class IsFirstTheSmallestOfThree{
    public static void Main(string[] args){
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 < number2 && number1 < number3){
            Console.WriteLine($"Is the first number {number1} the smallest? True");
        }
        else{
            Console.WriteLine($"Is the first number {number1} the smallest? False");
        }
    }
}

