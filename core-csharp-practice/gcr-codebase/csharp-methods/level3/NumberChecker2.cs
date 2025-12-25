/*  Method to find the smallest and second smallest elements in the digits array. Use Int32.MaxValue to initialize the variable.
 
3.Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Hint => 
a.Method to find the count of digits in the number and a Method to Store the digits of the number in a digits array
b.Method to find the sum of the digits of a number using the digits array
c. Method to find the sum of the squares of the digits of a number using the digits array. Use Math.Pow() method
d.Method to Check if a number is a Harshad number using a digits array. A number is called a Harshad number if it is divisible by the sum of its digits. For e.g. 21
e.Method to find the frequency of each digit in the number. Create a 2D array to store the frequency with digit in the first column and frequency in the second column.
*/

using System;

public class NumberChecker2{
      public static int CountDigits(int number){
            return number.ToString().Length;
      }

      public static int[] StoreDigits(int number){
            string numStr = number.ToString();
            int[] digits = new int[numStr.Length];
            for(int i=0; i<numStr.Length; i++){
                  digits[i] = (int)char.GetNumericValue(numStr[i]);
            }
            return digits;
      }

      public static int SumOfDigits(int[] digits){
            int sum = 0;
            foreach(int digit in digits){
                  sum += digit;
            }
            return sum;
      }

      public static double SumOfSquaresOfDigits(int[] digits){
            double sumOfSquares = 0;
            foreach(int digit in digits){
                  sumOfSquares += Math.Pow(digit, 2);
            }
            return sumOfSquares;
      }

      public static bool IsHarshadNumber(int number, int[] digits){
            int sum = SumOfDigits(digits);
            return number % sum == 0;
      }

      public static int[,] FrequencyOfDigits(int[] digits){
            int[,] frequency = new int[10, 2];

            for(int i=0; i<10; i++){
                  frequency[i, 0] = i; // Store the digit
                  frequency[i, 1] = 0; // Initialize frequency to 0
            }

            foreach(int digit in digits){
                  frequency[digit, 1]++; // Increment frequency
            }

            return frequency;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] digits = StoreDigits(number);

            int sum = SumOfDigits(digits);
            Console.WriteLine($"Sum of digits: {sum}");

            double sumOfSquares = SumOfSquaresOfDigits(digits);
            Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

            bool isHarshad = IsHarshadNumber(number, digits);
            Console.WriteLine($"Is Harshad Number: {isHarshad}");

            int[,] frequency = FrequencyOfDigits(digits);
            Console.WriteLine("Digit Frequency:");
            for(int i=0; i<10; i++){
                  if(frequency[i, 1] > 0){
                        Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
                  }
            }
      }
      
}