/*Write a program to find the sum of n natural numbers using recursive method and compare the result with the formulae n*(n+1)/2 and show the result from both computations is correct. 
Hint => 
a.Take the user input number and check whether it's a Natural number, if not exit
b.Write a Method to find the sum of n natural numbers using recursion
c. Write a Method to find the sum of n natural numbers using then*(n+1)/2 
d.Compare the two results and print the result*/

using System;

public class SumOfNaturalNumbers{
      public static int SumUsingRecursion(int n){
            if(n <= 1){
                  return n;
            }
            return n + SumUsingRecursion(n - 1);
      }

      public static int SumUsingFormula(int n){
            int result n * (n + 1) / 2;
            return result;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a natural number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number<1){
                  return;
            }

            int sumRecursion = SumUsingRecursion(number);
            int sumFormula = SumUsingFormula(number);

            Console.WriteLine($"Sum using recursion: {sumRecursion}");
            Console.WriteLine($"Sum using formula: {sumFormula}");

            if(sumRecursion == sumFormula){
                  Console.WriteLine("Both methods give the same result.");
            } else {
                  Console.WriteLine("The results from both methods do not match.");
            }
      }
}           