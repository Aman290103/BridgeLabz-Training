/*Count Vowels and Consonants
Problem:
Write a C# program to count the number of vowels and consonants in a given string.*/

using System;     

public class CountVowelsAndConsonants{
      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int vowelsCount = 0;  
            int consonantsCount = 0;

            for(int i=0;i<str.Length;i++){
                  char ch = char.ToLower(str[i]);
                  if((ch >= 'a' && ch <= 'z')){
                        if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'){
                              vowelsCount++;
                        } else {
                              consonantsCount++;
                        }
                  }
            }

            Console.WriteLine($"Vowels: {vowelsCount}");
            Console.WriteLine($"Consonants: {consonantsCount}");
      }
}