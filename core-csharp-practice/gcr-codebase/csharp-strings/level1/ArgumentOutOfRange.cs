/* Demonstrate ArgumentOutOfRangeException
Hint => 
Use string.Substring() with start index greater than the end index to generate an ArgumentOutOfRangeException.
Use try-catch to handle the exception.
*/

using System;

public class ArgumentOutOfRangeExceptionDemonstration{
      public void DemonstrateArgumentOutOfRange(string str , int startIndex, int endIndex){
            try{
                  string substr = str.Substring(startIndex, endIndex - startIndex);
                  Console.WriteLine("Substring: " + substr);
            }
            catch(ArgumentOutOfRangeException ex){
                  Console.WriteLine("ArgumentOutOfRangeException: " + ex.Message);
            }
      }

      public static void Main(string[] args){
            ArgumentOutOfRangeExceptionDemonstration aor = new ArgumentOutOfRangeExceptionDemonstration();
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter start index:");
            int startIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end index:");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            aor.DemonstrateArgumentOutOfRange(str, startIndex, endIndex);
      } 
}