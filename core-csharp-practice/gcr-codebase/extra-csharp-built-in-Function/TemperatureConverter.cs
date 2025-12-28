/*8. Temperature Converter:
Write a program that converts temperatures between Fahrenheit and Celsius.
● The program should have separate functions for converting from Fahrenheit to
Celsius and from Celsius to Fahrenheit.*/

using System;

public class TemperatureConverter{
      public static double FahrenheitToCelsius(double fahrenheit){
            return (fahrenheit - 32) * 5 / 9;
      }

      public static double CelsiusToFahrenheit(double celsius){
            return (celsius * 9 / 5) + 32;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius:F2}°C");

            Console.WriteLine("Enter temperature in Celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit:F2}°F");
      }     
}