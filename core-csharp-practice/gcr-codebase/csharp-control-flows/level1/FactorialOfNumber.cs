/*Write a Program to find the factorial of an integer entered by the user.
Hint => 
For example, the factorial of 4 is 1 * 2 * 3 * 4 which is 24.
Take an integer input from the user and assign it to the variable. Check the user has entered a positive integer.
Using a while loop, compute the factorial.
Print the factorial at the end.*/


using System;

public class FactorialOfNumber{
    public static void Main(string[] args){
        int number;
        int factorial = 1;
        int i = 1;

        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        while (i <= number)
        {
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }
}
