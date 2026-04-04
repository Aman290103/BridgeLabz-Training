/* Demonstrate NullReferenceException
Hint => 
Write a method to demonstrate NullReferenceException by accessing a method on a null string.
Use a try-catch block to handle the exception.
*/

using System;

public class NullReference{
      public void DemonstrateNullReferenceException(string? str){
            try{
                  int length = str.Length;
                  Console.WriteLine("Length of the string: " + length);
            }
            catch(NullReferenceException ex){
                  Console.WriteLine("NullReferenceException: " + ex.Message);
            }
      }
      public static void Main(string[] args){
            NullReference nre = new NullReference();
            string? nullString = null;
            nre.DemonstrateNullReferenceException(nullString);
      }
}