/*Write a program to take 2 numbers and print their quotient and reminder
Hint => 
Take user input as integer
Use division operator (/) for quotient and moduli operator (%) for reminder
Write Method to find the reminder and the quotient of a number */

using System;

public class QuotientAndRemainder{
      public static int[] findRemainderAndQuotient(int number, int divisor){
            int quotient = number/divisor;
            int remainder=number%divisor;

            int[] result = {quotient,remainder};
            return result;
      } 

      public static void Main(string[] args){
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int[] result = findRemainderAndQuotient(number,divisor);
            Console.WriteLine($"The quotient is {result[0]} and the remainder is {result[1]}");
      }
}
