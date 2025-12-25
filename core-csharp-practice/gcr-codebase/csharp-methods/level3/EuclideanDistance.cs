/*     Write a program Euclidean distance between two points as well as the equation of the line using those two points. Use Math functions Math.Pow() and Math.Sqrt()
Hint => 
a.Take inputs for 2 points x1, y1, and x2, y2 
b.Method to find the Euclidean distance between two points and return the distance
distance = (x2-x1)2 +(y2-y1)2
c.  Write a Method to find the equation of a line given two points and return the equation which includes the slope and the y-intercept
The equation of a line is given by the equation y = m*x + b Where m is the slope and b is the y-intercept. So firstly compute the slope using the formulae 
m = (y2 - y1)/(x2 - x1)
Post that compute the y-intercept b using the formulae 
b = y1 - m*x1  
Finally, return an array having slope m and y-intercept b */

using System;

public class EuclideanDistance{
      public static double FindDistance(double x1, double y1, double x2, double y2){
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
      }

      public static double[] FindLineEquation(double x1, double y1, double x2, double y2){
            double m = (y2 - y1) / (x2 - x1); // slope
            double b = y1 - m * x1; // y-intercept
            return new double[] { m, b };
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = FindDistance(x1, y1, x2, y2);
            double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

            Console.WriteLine($"Euclidean Distance: {distance}");
            Console.WriteLine($"Equation of the line: y = {lineEquation[0]}*x + {lineEquation[1]}");
      }
}
