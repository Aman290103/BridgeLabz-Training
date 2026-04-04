/*Write a program that takes a year as input and outputs the Year is a Leap Year or not 
Hint => 
a.The LeapYear program only works for year >= 1582, corresponding to a .Gregorian calendar. 
b.Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
c.Write a method to check for Leap Year using the conditions a and b
*/

using System;     

public class LeapYear{
      public static bool IsLeapYear(int year){
            if(year < 1582){
                  Console.WriteLine("Please enter a year greater than or equal to 1582.");
                  return false;
            }

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                  return true;
            } else {
                  return false;
            }
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isLeap = IsLeapYear(year);
            if(isLeap){
                  Console.WriteLine($"{year} is a Leap Year.");
            } else {
                  Console.WriteLine($"{year} is not a Leap Year.");
            }
      }
}