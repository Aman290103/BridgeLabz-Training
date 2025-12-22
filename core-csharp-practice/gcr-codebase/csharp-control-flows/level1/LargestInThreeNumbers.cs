/*Write a program to check if the first, second, or third number is the largest of the three.
I/P => number1, number2, number3
O/P => 
Is the first number the largest? ____
Is the second number the largest? ___
Is the third number the largest? ___*/

using System;

public class LargestInThreeNumbers{
    public static void Main(string[] args){
    
        Console.WriteLine("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 && number1 > number3){
            Console.WriteLine("Is the first number the largest? True");
        }
        else{
            Console.WriteLine("Is the first number the largest? False");
        }

        if (number2 > number1 && number2 > number3){
            Console.WriteLine("Is the second number the largest? True");
        }
        else{
            Console.WriteLine("Is the second number the largest? False");
        }

        if (number3 > number1 && number3 > number2){
            Console.WriteLine("Is the third number the largest? True");
        }
        else{
            Console.WriteLine("Is the third number the largest? False");
        }
    }
}

