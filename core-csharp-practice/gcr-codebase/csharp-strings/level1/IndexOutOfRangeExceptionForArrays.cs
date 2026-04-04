/*Demonstrate IndexOutOfRangeException for Arrays
Hint => 
Access an invalid index of an array to generate an IndexOutOfRangeException.
Use try-catch to handle the exception.*/

using System;

public class IndexOutOfBoundDemonstration{
      public void DemonstrateIndexOutOfBoundForArray(int[] arr){
            try{
                  int value = arr[arr.Length];
                  Console.WriteLine("Value at invalid index: " + value);
            }
            catch(IndexOutOfRangeException ex){
                  Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
      }
      public static void Main(string[] args){
            IndexOutOfBoundDemonstration iob = new IndexOutOfBoundDemonstration();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++){
                  arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            iob.DemonstrateIndexOutOfBoundForArray(arr);
      }
}