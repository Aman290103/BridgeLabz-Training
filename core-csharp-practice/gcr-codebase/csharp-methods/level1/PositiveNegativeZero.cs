/*Write a program to check whether a number is positive, negative, or zero.
Hint => Get integer input from the user. Write a Method to return -1 for negative number, 1 for positive number and 0 if number is zero
*/

using System;

public class positiveNegativeZero{
      public static int checknum(int num){
            if(num>0){
                  return 1;
            }
            else if(num==0){
                  return 0;
            }
            else{
                  return -1;
            }
      }      
            
      public static void Main(string[] args){
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = checknum(num);

            if(result==1){
                  Console.WriteLine("The number is positive");
            }
            else if(result==0){
                  Console.WriteLine("The number is zero");
            }
            else{
                  Console.WriteLine("The number is negative");
            }
      }      
           
      
}
