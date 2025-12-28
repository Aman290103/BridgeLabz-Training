/*5. Find the Longest Word in a Sentence
Problem:
Write a C# program that takes a sentence as input and returns the longest word in the
sentence.*/

using System;

public class LongestWord{
      public static string FindLongestWord(string sentence){
            string[] words = sentence.Split(' ');
            string longestWord ="";
            foreach(string word in words){
                  if(word.Length > longestWord.Length){
                        longestWord = word;
                  }
            }
            return longestWord;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string longestWord = FindLongestWord(sentence);

            Console.WriteLine($"The longest word is: {longestWord}");
      }     
}