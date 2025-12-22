/*Rewrite the program 10 to find the sum until the user enters 0 or a negative number using while loop and break statement
Hint => 
Use infinite while loop as in while (true)
Take the user entry and check if the user entered 0 or a negative number to break the loop using break*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                break;
            }
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum} ");
    }
}

