/*. Demonstrate IndexOutOfRangeException
Hint => 
Access an invalid index of a string using charAt() (string[index] in C#) to generate the exception.
Write another method with try-catch to handle the exception.
*/

using System;     

public class IndexOutOfBoundDemonstration{
      public void DemonstrateIndexOutOfBound(string str){
            try{
                  char ch = str[str.Length];
                  Console.WriteLine("Character at invalid index: " + ch);
            }
            catch(IndexOutOfRangeException ex){
                  Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
      }

      public static void Main(string[] args){
            IndexOutOfBoundDemonstration iob = new IndexOutOfBoundDemonstration();
            string str = Console.ReadLine();
            iob.DemonstrateIndexOutOfBound(str);
      }
}