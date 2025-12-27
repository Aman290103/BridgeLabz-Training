/*Compare Two Strings Using charAt()
Hint => 
Take user input using Console.ReadLine().
Create a method to compare two strings using CharAt() logic (string[index] in C#).
Compare the result with the built-in string.Equals().
*/

using System;

public class Program{
      public static bool CompareStrings(string str1, string str2){
            if (str1.Length != str2.Length){
                  return false;
            }
            for (int i = 0; i < str1.Length; i++){
                  if (str1[i] != str2[i]){
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

        if (CompareStrings(str1, str2)){
            Console.WriteLine("The strings are equal.");
        }
        else{
            Console.WriteLine("The strings are not equal.");
        }
    }   
}
