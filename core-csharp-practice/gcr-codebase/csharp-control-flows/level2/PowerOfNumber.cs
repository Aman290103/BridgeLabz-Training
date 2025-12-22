/*.Create a program to find the power of a number.
Hint => 
Get integer input for two variables named number and power.
Create a result variable with an initial value of 1.
Run a for loop from i = 1 to i <= power.
In each iteration of the loop, multiply the result with the number and assign the value to the result.
Finally, print the result*/

using System;

public class PowerOfNumber{
    public static void Main(string[] args){

        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++){
            result *= number;
        }
        Console.WriteLine("The result is " + result);
    }
}

