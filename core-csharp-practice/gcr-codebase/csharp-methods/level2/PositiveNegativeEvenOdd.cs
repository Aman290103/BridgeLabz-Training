/*Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less
Hint => 
a.Write a Method to Check whether the number is positive or negative
b.Write a Method to check whether the number is even or odd
c.Write a Method to compare two numbers and return 1 if number1 > number2 or 0 if both are equal or -1 if number1 < number2 
d.In the main program, Loop through the array using the length call the method isPositive() and if positive call method isEven() and print accordingly 
e.If the number is negative, print negative. 
f.Finally compare the first and last element of the array by calling the method compare() and display if they are equal, greater, or less*/

using System;

public class PositiveNegativeEvenOdd{
      public static bool IsPositive(int number){
            return number >= 0;
      }

      public static bool IsEven(int number){
            return number % 2 == 0;
      }

      public static int Compare(int number1, int number2){
            if(number1 > number2){
                  return 1;
            } else if(number1 < number2){
                  return -1;
            } else {
                  return 0;
            }
      }

      public static void Main(string[] args){
            int[] numbers = new int[5];

            for(int i=0; i<5; i++){
                  Console.WriteLine($"Enter number {i + 1}:");
                  numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<numbers.Length; i++){
                  if(IsPositive(numbers[i])){
                        if(IsEven(numbers[i])){
                              Console.WriteLine($"{numbers[i]} is Positive and Even");
                        } else {
                              Console.WriteLine($"{numbers[i]} is Positive and Odd");
                        }
                  } else {
                        Console.WriteLine($"{numbers[i]} is Negative");
                  }
            }

            int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
            if(comparisonResult == 1){
                  Console.WriteLine("The first number is greater than the last number.");
            } else if(comparisonResult == -1){
                  Console.WriteLine("The first number is less than the last number.");
            } else {
                  Console.WriteLine("The first and last numbers are equal.");
            }
      }
}