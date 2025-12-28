/*Remove Duplicates from a String
Problem:
Write a C# program to remove all duplicate characters from a given string and return the
modified string.*/

using System;

public class DuplicatesRemoval{
      public static string RemoveDuplicates(string str){
            string result ="";
            if(str.Length ==0){
                  return result;
            }
            for(int i=0;i<str,Length;i++){
                  char ch = str[i];
                  if(!result.Contains(ch)){
                        result += ch;
                  }
            }
            return result;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string modifiedString = RemoveDuplicates(str);

            Console.WriteLine($"String after removing duplicates: {modifiedString}");
      }     
}