/*Bus Route Distance Tracker 🚌
Each stop adds distance.
● Ask if the passenger wants to get off at a stop.
● Use a while-loop with a total distance tracker.
● Exit on user confirmation.*/

using System;

public class BusRouteDistanceTracker{
      public static void Main(string[] args){
            int totalDistance = 0;
            int stop = 1;
            string choice = "no";

            while(choice.ToLower() != "yes"){
                  Console.Write($"\nEnter distance covered to Stop {stop} (in km): ");
                  totalDistance += Convert.ToInt32(Console.ReadLine());
                  Console.Write("Do you want to get off at this stop? (yes/no): ");
                  choice = Console.ReadLine();
                  stop++;
            }

            
        Console.WriteLine("\nPassenger got off the bus.");
        Console.WriteLine("Final distance traveled: " + totalDistance + " km");
      }


}