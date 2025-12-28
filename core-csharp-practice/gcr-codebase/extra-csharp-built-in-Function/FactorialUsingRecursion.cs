/*6. Factorial Using Recursion:
Write a program that calculates the factorial of a number using a recursive function.
● Include modular code to separate input, calculation, and output processes.*/

using System;

public class FactorialUsingRecursion{
      public static int GetInput(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
      }

      public static long Factorial(int number){
            if(number <= 1){
                  return 1;
            }
            return number * Factorial(number - 1);
      }

      public static void Main(string[] args){
            int number = GetInput("Enter a non-negative integer to calculate its factorial:");

            if(number < 0){
                  Console.WriteLine("Factorial is not defined for negative numbers.");
                  return;
            }

            long result = Factorial(number);

            Console.WriteLine($"The factorial of {number} is: {result}");
      }     
}