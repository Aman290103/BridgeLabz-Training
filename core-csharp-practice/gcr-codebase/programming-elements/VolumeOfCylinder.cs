using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        double radius = 7;
        double height = 10;

        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of Cylinder = " + volume);
    }
}
