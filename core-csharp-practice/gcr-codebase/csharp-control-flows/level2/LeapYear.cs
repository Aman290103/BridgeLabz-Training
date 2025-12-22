/*Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year. 
Hint => 
The LeapYear program only works for year >= 1582, corresponding to a year in the Gregorian calendar. So ensure to check for the same. 
Further, the Leap Year is a Year divisible by 4 and not 100 unless it is divisible by 400. E.g. 1800 is not a Leap Year and 2000 is a Leap Year.
Write code having multiple if else statements based on conditions provided above and a second part having only one if statement and multiple logical 
Rewrite program 1 to determine Leap Year with single if condition using logical and && and or || operators*/

using System;

public class LeapYear{
    public static void Main(string[] args){
        Console.WriteLine("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year is not in the Gregorian calendar");
        }
        else if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("Year is a Leap Year");
        }
        else
        {
            Console.WriteLine("Year is not a Leap Year");
        }
    }
}
