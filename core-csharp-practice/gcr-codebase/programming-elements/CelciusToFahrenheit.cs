using System;

class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        double celsius = 25;

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }
}
