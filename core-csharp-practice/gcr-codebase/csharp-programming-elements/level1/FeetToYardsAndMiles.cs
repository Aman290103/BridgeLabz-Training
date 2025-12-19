/*14. Write a program to find the distance in yards and miles for the distance provided by the user in feet.
Hint:
1 yard = 3 feet
1 mile = 1760 yards
Input:
distanceInFeet
Output:
Distance in yards___________ and Distance in miles____________*/


using System;

public class FeetToYardsAndMiles
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine($"Distance in yards: {distanceInYards} and Distance in miles: {distanceInMiles}");
    }
}
