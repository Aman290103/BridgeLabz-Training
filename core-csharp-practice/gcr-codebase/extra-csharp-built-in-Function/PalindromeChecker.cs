/*Palindrome Checker:
Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
● Break the program into functions for input, checking the palindrome condition, and
displaying the result.*/

using System;

public class PalindromeChecker{
      public static string GetInput(){
            Console.WriteLine("Enter a string:");
            return Console.ReadLine();
      }

      public static bool CheckPalindrome(string str){
            int left =0;
            int right = str.Length -1;
            while(left < right){
                  if(str[left] != str[right]){
                        return false;
                  }
                  left++;
                  right--;
            }
            return true;
      }

      public static void DisplayResult(string str, bool isPalindrome){
            if(isPalindrome){
                  Console.WriteLine($"'{str}' is a palindrome.");
            } else {
                  Console.WriteLine($"'{str}' is not a palindrome.");
            }
      }

      public static void Main(string[] args){
            string input = GetInput();
            bool result = CheckPalindrome(input);
            DisplayResult(input, result);
      }     
}