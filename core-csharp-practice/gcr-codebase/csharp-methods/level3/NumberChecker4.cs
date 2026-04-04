/*    Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Hint => 
a.Method to Check if a number is a prime number. A prime number is a number greater than 1 that has no positive divisors other than 1 and itself. 
b.Method to Check if a number is a neon number. A neon number is a number where the sum of digits of the square of the number is equal to the number itself 
c. Method to Check if a number is a spy number. A number is called a spy number if the sum of its digits is equal to the product of its digits
d.Method to Check if a number is an automorphic number. An automorphic number is a number whose square ends with the number itself. E.g. 5 is an automorphic number
e. Method to Check if a number is a buzz number. A buzz number is a number that is either divisible by 7 or ends with 7
*/

using System;

public class NumberChecker4{
      public static bool IsPrime(int number){
            if(number <= 1) return false;
            for(int i=2; i<=Math.Sqrt(number); i++){
                  if(number % i == 0) return false;
            }
            return true;
      }

      public static bool IsNeon(int number){
            int square = number * number;
            int sum = 0;
            while(square > 0){
                  sum += square % 10;
                  square /= 10;
            }
            return sum == number;
      }

      public static bool IsSpy(int number){
            int sum = 0;
            int product = 1;
            while(number > 0){
                  int digit = number % 10;
                  sum += digit;
                  product *= digit;
                  number /= 10;
            }
            return sum == product;
      }

      public static bool IsAutomorphic(int number){
            int square = number * number;
            string numStr = number.ToString();
            string squareStr = square.ToString();
            return squareStr.EndsWith(numStr);
      }

      public static bool IsBuzz(int number){
            return number % 7 == 0 || number % 10 == 7;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number} is Prime: {IsPrime(number)}");
            Console.WriteLine($"{number} is Neon: {IsNeon(number)}");
            Console.WriteLine($"{number} is Spy: {IsSpy(number)}");
            Console.WriteLine($"{number} is Automorphic: {IsAutomorphic(number)}");
            Console.WriteLine($"{number} is Buzz: {IsBuzz(number)}");
      }     
}