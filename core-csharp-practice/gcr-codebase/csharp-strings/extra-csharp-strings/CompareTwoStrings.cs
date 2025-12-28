/*Compare Two Strings
Problem:
Write a C# program to compare two strings lexicographically (dictionary order) without
using built-in compare methods.
Example Input:
String 1: "apple"
String 2: "banana"
Expected Output:
"apple" comes before "banana" in lexicographical order*/

using System;     

public class CompareTwoStrings{
      public static int LexicographicalCompare(string str1, string str2){
            int len = Math.Min(str1.Length, str2.Length);
            for(int i=0;i<len;i++){
                  if(str1[i] != str2[i]){
                        return str1[i] - str2[i];
                  }
            }
            return str1.Length - str2.Length;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            int result = LexicographicalCompare(str1, str2);

            if(result < 0){
                  Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
            } else if(result > 0){
                  Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order.");
            } else {
                  Console.WriteLine($"\"{str1}\" is equal to \"{str2}\".");
            }
      }
}