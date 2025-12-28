/*3. Palindrome String Check
Problem:
Write a C# program to check if a given string is a palindrome (a string that reads the
same forward and backward).*/

using System;     

public class PalindromeString{
      public static bool IsPalindrome(string str){
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

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            bool result = IsPalindrome(str);

            if(result){
                  Console.WriteLine($"'{str}' is a palindrome.");
            } else {
                  Console.WriteLine($"'{str}' is not a palindrome.");
            }
      }
}