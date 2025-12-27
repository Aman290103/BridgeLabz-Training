/* Convert Text to Uppercase
Hint => 
Write a method to convert each character in a string to uppercase using ASCII logic (char manipulation).
Compare the result with the built-in string.ToUpper().
*/

using System;

public class UpperCaseConversion{
      public static string ConvertToUpperCase(string str){
            char[] upperChars = new char[str.Length];
            for (int i = 0; i < str.Length; i++){
                  char ch = str[i];
                  if (ch >= 'a' && ch <= 'z'){
                        upperChars[i] = (char)(ch - 32);
                  } else {
                        upperChars[i] = ch;
                  }
            }
            return new string(upperChars);
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string convertedUpper = ConvertToUpperCase(input);
            string InbuiltUpper = input.ToUpper();

            Console.WriteLine("Convert to Uppercase: " + convertedUpper);
            Console.WriteLine("in-built Uppercase: " + InbuiltUpper);

            if (convertedUpper == InbuiltUpper){
                  Console.WriteLine("Both methods gives the same result");
            } else {
                  Console.WriteLine("Results are different");
            }
      }
}