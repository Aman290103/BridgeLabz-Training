/*/*Write a Program to find the factorial of an integer entered by the user.
Hint => 
For example, the factorial of 4 is 1 * 2 * 3 * 4 which is 24.
Take an integer input from the user and assign it to the variable. Check the user has entered a positive integer.
Using a For-loop, compute the factorial.
Print the factorial at the end.*/

using System;

public class FactorialOfNumber{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"The factorial of {num} is: {factorial}");
    }
}
