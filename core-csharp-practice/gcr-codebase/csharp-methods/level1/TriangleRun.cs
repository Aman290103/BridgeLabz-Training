/*An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete
Hint => 
Take user input for 3 sides of a triangle 
The perimeter of a triangle is the addition of all sides and rounds is distance/perimeter
Write a Method to compute the number of rounds user needs to do to complete 5km run
*/

using System;

public class TriangleRun{
      public static double calculateRounds(double side1,double side2, double side3){
            
            double perimeter = side1+side2+side3;
            double totalDistance = 5000;

            double rounds = totalDistance/perimeter;

            return rounds;
      }

      public static void Main(string[] args){

            Console.WriteLine("Enter side 1 of the triangle (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side 2 of the triangle (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side 3 of the triangle (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double rounds = calculateRounds(side1,side2,side3);
            Console.WriteLine($"the number of rounds are {rounds}");
      }
}