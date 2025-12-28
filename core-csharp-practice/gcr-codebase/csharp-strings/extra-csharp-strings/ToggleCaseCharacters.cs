/*Toggle Case of Characters
Problem:
Write a C# program to toggle the case of each character in a given string. Convert
uppercase letters to lowercase and vice versa. */     

using System;

public class ToggleCaseCharacters{
      public static string ToggleCase(string str){
            char[] charArr = new char[str.Length];
            for(int i=0;i<str.Length;i++){
                  char ch = str[i];
                  if(char.IsUpper(ch)){
                        charArr[i] = char.ToLower(ch);
                  } else if(char.IsLower(ch)){
                        charArr[i] = char.ToUpper(ch);
                  } else {
                        charArr[i] = ch;
                  }
            }
            return new string(charArr);
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string toggledString = ToggleCase(str);

            Console.WriteLine($"Toggled Case String: {toggledString}");
      }     
}