/*Demonstrate FormatException
Hint => 
Use int.Parse() on a non-numeric string to generate FormatException.
Use try-catch to handle the exception.
*/
using System;

public class FormatExceptionDemonstration{
      public void DemonstrateFormatException(string str){
            try{
                  int number = int.Parse(str);
                  Console.WriteLine("Parsed number: " + number);
            }
            catch(FormatException ex){
                  Console.WriteLine("FormatException: " + ex.Message);
            }
      }

      public static void Main(string[] args){
            FormatExceptionDemonstration fed = new FormatExceptionDemonstration();
            Console.WriteLine("Enter a non-numeric string to parse as integer:");
            string str = Console.ReadLine();
            fed.DemonstrateFormatException(str);      
      }
}