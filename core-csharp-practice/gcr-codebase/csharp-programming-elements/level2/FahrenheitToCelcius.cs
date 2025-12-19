/*5. Write a TemperatureConversion program, given the temperature in Fahrenheit as input that outputs the temperature in Celsius
Hint:
Create a fahrenheit variable and take the user's input.
Use the formula: Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
Assign the result to celsiusResult and print the result.
I/P => fahrenheit
O/P => The ___ Fahrenheit is ___ Celsius*/

using System;

public class FahrenheitToCelcius{
    public static void Main(string[] args){
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");
    }
}

