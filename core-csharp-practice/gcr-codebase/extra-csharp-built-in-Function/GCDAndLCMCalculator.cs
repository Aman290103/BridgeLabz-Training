/*GCD and LCM Calculator:
Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
Multiple (LCM) of two numbers using functions.
● Use separate functions for GCD and LCM calculations, showcasing how modular code
works.*/

using System;     

public class GCDAndLCMCalculator{
      public static int GetInput(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
      }

      public static int CalculateGCD(int a, int b){
            while(b != 0){
                  int temp = b;
                  b = a % b;
                  a = temp;
            }
            return a;
      }

      public static int CalculateLCM(int a, int b){
            return (a * b) / CalculateGCD(a, b);
      }

      public static void Main(string[] args){
            int number1 = GetInput("Enter the first integer:");
            int number2 = GetInput("Enter the second integer:");

            int gcd = CalculateGCD(number1, number2);
            int lcm = CalculateLCM(number1, number2);

            Console.WriteLine($"The GCD of {number1} and {number2} is: {gcd}");
            Console.WriteLine($"The LCM of {number1} and {number2} is: {lcm}");
      }     
}     