/*Write a program to calculate various trigonometric functions using Math class given an angle in degrees
Hint => 
Method to calculate various trigonometric functions, Firstly convert to radians and then use Math function to find sine, cosine and tangent.*/

using System;

public class TrigonometricFunctions{
      public static double[] calculateTrigonometricFunctions(double angle){
            double radians = angle * (Math.PI / 180);
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[]{sine,cosine,tangent};
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            double[] trigFunctions = calculateTrigonometricFunctions(angle);
            Console.WriteLine($"For angle {angle} degrees:");
            Console.WriteLine($"Sine: {trigFunctions[0]}");
            Console.WriteLine($"Cosine: {trigFunctions[1]}");
            Console.WriteLine($"Tangent: {trigFunctions[2]}");
      }
}
