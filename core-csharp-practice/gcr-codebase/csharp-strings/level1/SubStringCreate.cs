/*. Create a Substring Using charAt()
      Hint => 
Take user input using Console.ReadLine() for string, start index, and end index.
Write a method to create a substring using charAt() (string[index] in C#).
Use string.Substring() to generate the substring and compare the results.
*/

using System;

public class SubStringCreate{
      public static string CreateSubstring(string str, int start, int end){
            string result = "";
            for (int i = start; i < end; i++){
                  result += str[i];
            }
            return result;
      }
      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter start index:");
            int startIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end index:");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            string createdSubstring = CreateSubstring(str, startIndex, endIndex);
            string InbuiltSubstring = str.Substring(startIndex, endIndex - startIndex);

            Console.WriteLine($"Custom Substring: {createdSubstring}");
            Console.WriteLine($"in-built Substring: {InbuiltSubstring}");

            if (createdSubstring == InbuiltSubstring){
                  Console.WriteLine("Both substrings are equal.");
            } else {
                  Console.WriteLine("Substrings are not equal.");
            }
      }
}