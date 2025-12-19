/*
4. Write a TemperatureConversion program, given the temperature in Celsius as input that outputs the temperature in Fahrenheit
Hint:
Create a celsius variable and take the temperature as user input.
Use the formula: Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
Assign the result to fahrenheitResult and print the result.
I/P => celsius
O/P => The ___ Celsius is ___ Fahrenheit*/

using System;

public class TemperatureConversion{
    public static void Main(string[] args){
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9/5) + 32;

        Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}

