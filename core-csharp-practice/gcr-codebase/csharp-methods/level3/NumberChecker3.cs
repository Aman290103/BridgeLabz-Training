/*Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Hint => 
a.Method to find the count of digits in the number and a Method to Store the digits of the number in a digits array
b.Method to reverse the digits array 
c. Method to compare two arrays and check if they are equal
d.Method to check if a number is a palindrome using the Digits. A palindrome number is a number that remains the same when its digits are reversed. 
e.Method to Check if a number is a duck number using the digits array. A duck number is a number that has a non-zero digit present in it
*/

using System;

public class NumberChecker3{
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

      public static int[] ReverseDigits(int[] digits){
            Array.Reverse(digits);
            return digits;
      }

      public static bool AreArraysEqual(int[] array1, int[] array2){
            if(array1.Length != array2.Length){
                  return false;
            }
            for(int i=0; i<array1.Length; i++){
                  if(array1[i] != array2[i]){
                        return false;
                  }
            }
            return true;
      }
      public static bool IsPalindrome(int number, int[] digits){
            int[] reversedDigits = ReverseDigits((int[])digits.Clone());
            return AreArraysEqual(digits, reversedDigits);
      }
      public static bool IsDuckNumber(int[] digits){
            foreach(int digit in digits){
                  if(digit == 0){
                        return true;
                  }
            }
            return false;
      }
      public static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = CountDigits(number);
            Console.WriteLine($"Count of digits: {digitCount}");

            int[] digits = StoreDigits(number);
            Console.WriteLine("Digits stored in array: " + string.Join(", ", digits));

            int[] reversedDigits = ReverseDigits((int[])digits.Clone());
            Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits));

            bool isPalindrome = IsPalindrome(number, digits);
            Console.WriteLine($"Is the number a palindrome? {isPalindrome}");

            bool isDuckNumber = IsDuckNumber(digits);
            Console.WriteLine($"Is the number a duck number? {isDuckNumber}");
      }
}