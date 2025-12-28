/*Write a C# program that accepts two strings from the user and checks if the two
strings are anagrams of each other (i.e., whether they contain the same characters in any
order).*/

using System;     

public class CheckForAnagrams{
      public static bool AreAnagrams(string str1, string str2){
            if(str1.Length != str2.Length){
                  return false;
            }

            int[] charCount = new int[256];

            for(int i=0;i<str1.Length;i++){
                  charCount[(int)str1[i]]++;
                  charCount[(int)str2[i]]--;
            }

            for(int i=0;i<256;i++){
                  if(charCount[i] != 0){
                        return false;
                  }
            }

            return true;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            bool result = AreAnagrams(str1, str2);

            if(result){
                  Console.WriteLine($"\"{str1}\" and \"{str2}\" are anagrams.");
            } else {
                  Console.WriteLine($"\"{str1}\" and \"{str2}\" are not anagrams.");
            }
      }
}