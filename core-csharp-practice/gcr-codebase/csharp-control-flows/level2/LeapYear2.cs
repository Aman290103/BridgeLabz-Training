//Rewrite program 1 to determine Leap Year with single if condition using logical and && and or || operators

using System;

public class LeapYear{
    static void Main(){

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0){
            Console.WriteLine(year + " is a leap year.");
        }
        else{
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}

