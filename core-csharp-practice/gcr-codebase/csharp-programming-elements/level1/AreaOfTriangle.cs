/*12. Write a program that takes the base and height to find the area of a triangle in square
inches and square centimeters
Hint: Area of a Triangle is 1⁄2 * base * height
I/P => base, height
O/P => Area of the triangle is _______ square inches and ______ square centimeters */

using System;

public class AreaOfTriangle
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the base of the triangle (in inches): ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle (in inches): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Area in square inches
        double areaInInches = 0.5 * baseLength * height;

        // Convert inches to centimeters (1 inch = 2.54 cm)
        double baseInCm = baseLength * 2.54;
        double heightInCm = height * 2.54;

        // Area in square centimeters
        double areaInCentimeters = 0.5 * baseInCm * heightInCm;

        Console.WriteLine($"Area of the triangle is {areaInInches} square inches, {areaInCentimeters:F2} square centimeters");
    }
}
