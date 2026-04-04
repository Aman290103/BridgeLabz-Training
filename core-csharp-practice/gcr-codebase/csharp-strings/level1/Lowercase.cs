/* Convert Text to Lowercase
Hint => 
Write a method to convert each character in a string to lowercase using ASCII logic (char manipulation).
Compare the result with the built-in string.ToLower().
*/

using System;

public class LowerCaseConversion{
      public static string ConvertToLowerCase(string str){
            char[] LowerChars = new char[str.length];
            for(int i=0;i<str.length;i++){
                  char ch = str[i];
                  if(ch>='A' && ch<='Z'){
                        LowerChars[i]=(char)(ch+32);
                  } else{
                        LowerChars[i]=ch;
                  }
                  
            }
            return new string(LowerChars);
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string convertedLower = ConvertToLowerCase(input);
            string InbuiltLower = input.ToLower();

            Console.WriteLine("Convert to Lowercase: " + convertedLower);
            Console.WriteLine("in-built Lowercase: " + InbuiltLower);

            if (convertedLower == InbuiltLower){
                  Console.WriteLine("Both methods gives the same result");
            } else {
                  Console.WriteLine("Results are different");
            }
      }
}