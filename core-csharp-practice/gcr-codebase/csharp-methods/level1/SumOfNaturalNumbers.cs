/*Write a program to find the sum of n natural numbers using loop
Hint => Get integer input from the user. Write a Method to find the sum of n natural numbers using loop */

using System;

public class SumOfNaturalNumbers{
      public int sumOfNaturalNumbers(int n){
            int sum = n*(n+1)/2;
            return sum;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            SumOfNaturalNumbers sum = new SumOfNaturalNumbers();
            int  result = sum.sumOfNaturalNumbers(n);

            Console.WriteLine($"The sum of first {n} natural Numbers is: {result}");
      }
}

