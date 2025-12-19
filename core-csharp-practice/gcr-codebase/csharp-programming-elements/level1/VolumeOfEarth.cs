/*7. Write a Program to compute the volume of Earth in km^3 and miles^3
Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____*/

using System;

public class volumeOfEarth{
      public static void Main(string[] args){
          double pi=3.14;
          double radius=6378;
          double volumeOfEarth=(4/3)*pi*radius*radius*radius;
          double volumeOfEarthInMiles=volumeOfEarth*0.621371;
          Console.WriteLine($"The volume of earth in cubic kilometers is {volumeOfEarth} and cubic miles is {volumeOfEarthInMiles}");
      }
}