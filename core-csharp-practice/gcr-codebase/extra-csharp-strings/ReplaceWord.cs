/*12. Write a replace method in C# that replaces a given word with another word in a
sentence:*/

using System;

public class ReplaceWord{
      public static string ReplaceWordInSentence(string sentence, string oldWord, string newWord){
            return sentence.Replace(oldWord, newWord);
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter the word to be replaced:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter the new word:");
            string newWord = Console.ReadLine();

            string updatedSentence = ReplaceWordInSentence(sentence, oldWord, newWord);

            Console.WriteLine($"Modified Sentence: {updatedSentence}");
      }     
}