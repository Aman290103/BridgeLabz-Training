/*Return All Characters Without Using ToCharArray()
Hint => 
Write a method to return characters of a string without using ToCharArray() (loop through string[index]).
Compare the result with the built-in ToCharArray() method.
*/

using System;

public class CharactersOfString{
      public static char[] GetCharacters(string str){
            char[] chars = new char[str.Length];
            for (int i = 0; i < str.Length; i++){
                  chars[i] = str[i];
            }
            return chars;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();

            char[] GetChars = GetCharacters(s);
            char[] inbuiltChars = s.ToCharArray();

            Console.WriteLine("Characters using getCharacters method:");
            foreach (char c in GetChars){
                  Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Characters using in-built ToCharArray():");
            foreach (char c in inbuiltChars){
                  Console.Write(c + " ");
            }
            Console.WriteLine();

            bool areEqual = true;
            if (customChars.Length != inbuiltChars.Length){
                  areEqual = false;
            }
            else{
                  for (int i = 0; i < customChars.Length; i++){
                        if (customChars[i] != inbuiltChars[i]){
                              areEqual = false;
                              break;
                        }
                  }
            }
            if (areEqual){
                  Console.WriteLine("Both character arrays are equal.");
            } else {
                  Console.WriteLine("Character arrays are not equal.");
            }
      }
}