/*Reverse a String
Problem:
Write a C# program to reverse a given string without using any built-in reverse functions.*/

using System;

public class StringReverse{
      public static string ReverseString(string str){
            char[] charArr = new char[str.Length];
            for(int i=0;i<str.Length;i++){
                  charArr[i] = str[str.Length - 1 - i];
            }
            return new string(charArr);
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string reversedString = ReverseString(str);

            Console.WriteLine($"Reversed String: {reversedString}");
      }     
}