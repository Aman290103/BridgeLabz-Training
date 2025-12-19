/*8. Create a program to convert distance in kilometers to miles.
Hint:
Create a variable km and assign type as double as in double km;
Create Scanner Object to take user input from Standard Input that is the Keyboard as in
Scanner input = new Scanner(System.in);
Use Scanner Object to take user input for km as in km = input.nextInt();
Use 1 mile = 1.6 km formulae to calculate miles and show the output
I/P => km
O/P => The total miles is ___ mile for the given ___ km*/

using System;

public class kilometersToMiles{
      public static void Main(string [] args){
        Console.WriteLine("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers / 1.6;
        Console.WriteLine($"The total miles is {miles} miles for the given {kilometers} kilometers");
      }
}