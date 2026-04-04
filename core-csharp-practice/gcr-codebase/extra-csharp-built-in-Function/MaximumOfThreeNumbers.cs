/*Maximum of Three Numbers:
Write a program that takes three integer inputs from the user and finds the maximum of the
three numbers.
● Ensure your program follows best practices for organizing code into modular
functions, such as separate functions for taking input and calculating the maximum
value.*/

using System;     

public class MaximumOfThreeNumbers{
      public static int GetInput(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
      }

      public static int FindMaximum(int num1, int num2, int num3){
            int max = num1;

            if(num2 > max){
                  max = num2;
            }
            if(num3 > max){
                  max = num3;
            }

            return max;
      }

      public static void Main(string[] args){
            int number1 = GetInput("Enter the first integer:");
            int number2 = GetInput("Enter the second integer:");
            int number3 = GetInput("Enter the third integer:");

            int maximum = FindMaximum(number1, number2, number3);

            Console.WriteLine($"The maximum of the three numbers is: {maximum}");
      }     
}