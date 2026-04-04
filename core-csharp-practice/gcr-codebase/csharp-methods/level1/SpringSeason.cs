/*Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
Hint => Spring Season is from March 20 to June 20. Write a Method to check for Spring season and return a boolean true or false 
*/

using System;

public class SpringSeason{
      public static bool checkSpringSeason(int month, int day){
            if(month==3 && day>=20 || month==4 || month==5 || month==6 && day<=20){
                  return true;
            }
            else{
                  return false;
            }
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the Month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Day:");
            int day = Convert.ToInt32(Console.ReadLine());

            bool isSpring = checkSpringSeason(month, day);

            if(isSpring){
                  Console.WriteLine("Its a Spring Season");
            }
            else{
                  Console.WriteLine("Not a Spring Season");
            }
      }
}
