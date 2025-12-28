/*3. Prime Number Checker:
Create a program that checks whether a given number is a prime number.
● The program should use a separate function to perform the prime check and return
the result.*/

using System;

public class PrimeNumberChecker{
      public static bool IsPrime(int number){
            if(number <= 1){
                  return false;
            }
            for(int i=2;i<= Math.Sqrt(number);i++){
                  if(number % i ==0){
                        return false;
                  }
            }
            return true;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = IsPrime(number);

            if(result){
                  Console.WriteLine($"{number} is a prime number.");
            } else {
                  Console.WriteLine($"{number} is not a prime number.");
            }
      }     
}     