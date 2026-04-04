/*Remove a Specific Character from a String
Problem:
Write a C# program to remove all occurrences of a specific character from a string.
Example Input:
String: "Hello World"
Character to Remove: 'l'
Expected Output:
Modified String: "Heo Word"*/

using System;

public class RemoveSpecificWord{
      public static string RemoveCharacter(string str, char charToRemove){
            string result = "";
            for(int i=0;i<str.Length;i++){
                  if(str[i] != charToRemove){
                        result += str[i];
                  }
            }
            return result;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the character to remove:");
            char charToRemove = Console.ReadLine()[0];

            string updatedString = RemoveCharacter(str, charToRemove);

            Console.WriteLine($"updated String: {updatedString}");
      }     
}