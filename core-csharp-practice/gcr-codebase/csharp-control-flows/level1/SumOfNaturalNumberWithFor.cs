/*Rewrite the program number 12 with the for loop instead of a while loop to find the sum of n Natural Numbers. 
Hint => 
Take the user input number and check whether it's a Natural number
If it's a natural number Compute using formulae as well as compute using for loop
Compare the two results and print the result.*/

using System;

public class Program{
    public static void Main(string[] args){
        int n;
        int sum = 0;
        Console.WriteLine("Enter a positive integer: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);
    }
}

