/*Write a program to check whether a number is positive, negative, or zero.
Hint => 
Get integer input from the user and store it in the number variable.
If the number is positive, print positive.
If the number is negative, print negative.
If the number is zero, print zero.*/

using System;

public class PositiveNegativeOrZero{
    public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0){
            Console.WriteLine("positive");
        }
        else if (number < 0){
            Console.WriteLine("negative");
        }
        else{
            Console.WriteLine("zero");
        }
    }
}

