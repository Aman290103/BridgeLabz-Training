/*Find Substring Occurrences
Problem:
Write a C# program to count how many times a given substring occurs in a string.*/

using System;

public class SubStringOccurrence{
      public static int CountSubstringOccurrences(string str, string substr){
            int count = 0;
            int index = 0;

            while((index = str.IndexOf(substr, index)) != -1){
                  count++;
                  index += substr.Length;
            }

            return count;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the main string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the substring to search for:");
            string substr = Console.ReadLine();

            int occurrences = CountSubstringOccurrences(str, substr);

            Console.WriteLine($"The substring '{substr}' occurs {occurrences} times in the string.");
      }     
}