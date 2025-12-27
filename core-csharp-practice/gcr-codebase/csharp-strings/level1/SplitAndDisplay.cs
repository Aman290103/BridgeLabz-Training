/*Split Text into Words and Display Word Lengths
Hint => 
Write a method to split text into words without using string.Split(). Use char comparison for spaces.
Write another method to calculate string length without string.Length.
Return a 2D array where each row contains the word and its length.
*/

using System;     

public class SplitAndDisplay{
      public static string[,] SplitTextAndCalculateLengths(string str){
            int wordCount = 1;
            for (int i = 0; i < str.Length; i++){
                  if (str[i] == ' '){
                        wordCount++;
                  }
            }
            string[,] result = new string[wordCount, 2];
            int wordIndex = 0;
            int charIndex = 0;
            char[] currentWord = new char[str.Length];
            for (int i = 0; i <= str.Length; i++){
                  if (i == str.Length || str[i] == ' '){
                        string word = new string(currentWord, 0, charIndex);
                        result[wordIndex, 0] = word;
                        result[wordIndex, 1] = CalculateLength(word).ToString();
                        wordIndex++;
                        charIndex = 0;
                  } else {
                        currentWord[charIndex++] = str[i];
                  }
            }
            return result;
      }
      public static int CalculateLength(string str){
            int length = 0;
            foreach (char c in str){
                  length++;
            }
            return length;
      }
      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string[,] wordsAndLengths = SplitTextAndCalculateLengths(input);

            Console.WriteLine("Words and their lengths:");
            for (int i = 0; i < wordsAndLengths.GetLength(0); i++){
                  Console.WriteLine($"Word: '{wordsAndLengths[i, 0]}', Length: {wordsAndLengths[i, 1]}");
            }  
      }
}