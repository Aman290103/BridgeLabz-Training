/*3. Create a program to convert the distance of 10.8 kilometers to miles.
Hint: 1 km = 1.6 miles
I/P => NONE
O/P => The distance ___ km in miles is ___*/

using System;

public class kilometersToMiles{
      public static void Main(string[] args){
        double kilometers = 10.8;
        double miles = kilometers * 1.6;
        Console.WriteLine($"The distance {kilometers} km in miles is {miles}");
      }
}