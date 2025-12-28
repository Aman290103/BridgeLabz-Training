/*Fibonacci Sequence Generator:
Write a program that generates the Fibonacci sequence up to a specified number of terms
entered by the user.
● Organize the code by creating a function that calculates and prints the Fibonacci
sequence.*/

using System;

public class FibonacciSequenceGenerator{
      public static void GenerateFibonacci(int terms){
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Sequence:");

            for(int i=0;i<terms;i++){
                  if(i == 0){
                        Console.Write(first + " ");
                        continue;
                  }
                  if(i == 1){
                        Console.Write(second + " ");
                        continue;
                  }
                  next = first + second;
                  Console.Write(next + " ");
                  first = second;
                  second = next;
            }
            Console.WriteLine();
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the number of terms for Fibonacci sequence:");
            int terms = Convert.ToInt32(Console.ReadLine());

            GenerateFibonacci(terms);
      }     
}