/*Write a program FizzBuzz, take a number as user input, and if it is a positive integer loop from 0 to the number and print the number, but for multiples of 3 print "Fizz" instead of the number, for multiples of 5 print "Buzz", and for multiples of both print "FizzBuzz".
Hint => 
Write the program and use for loop*/

using System;

public class FizzBuzz{
    public static void Main(string[] args){
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        for (int i = 0; i <= number; i++){
            if (i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0){
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
        }
    }
}

