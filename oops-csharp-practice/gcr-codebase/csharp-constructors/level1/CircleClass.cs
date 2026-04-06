/*Circle Class
Write a Circle class with a radius attribute.
Use constructor chaining to initialize radius with both default and user-provided values.
*/

using System;

public class circle{
      public double radius;
      public circle(){
        radius = 1.0;
      }
      public circle(double radius){
        this.radius = radius;
      }     
}
public class CircleClass{
      public static void Main(string[] args){
        circle c1 = new circle();
        circle c2 = new circle(2.0);
        Console.WriteLine("Radius of c1: " + c1.radius);
        Console.WriteLine("Radius of c2: " + c2.radius);
      }
}