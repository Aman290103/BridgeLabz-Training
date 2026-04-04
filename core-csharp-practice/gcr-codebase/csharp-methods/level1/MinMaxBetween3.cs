/*Write a program to find the smallest and the largest of the 3 numbers.
Hint => 
Take user input for 3 numbers
Write a single method to find the smallest and largest of the three numbers
Output “The smallest number is ___ and the largest number is ___” */

using System;

public class MinMaxBetween3{
      public static int[] check(int num1, int num2, int num3){
            int max=num1;
            if(num2>max){
                  max=num2;
            } 
            if(num3>max){
                  max=num3;
            }

            int min =num1;
            if(min>num2){
                  min=num2;
            }
            if(min>num3){
                  min=num3;
            }

            return [min,max];

      }

      public static void Main(string[] args){
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] result = check(num1,num2,num3);
            Console.WriteLine($"The smallest number is {result[0]} and the largest number is {result[1]}");
      }
}