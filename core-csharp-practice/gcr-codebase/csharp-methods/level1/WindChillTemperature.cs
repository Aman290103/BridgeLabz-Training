/*Write a program calculate the wind chill temperature given the temperature and wind speed
Hint => 
Write a method to calculate the wind chill temperature using the formula 
windChill = 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * windSpeed0.16 
public double CalculateWindChill(double temperature, double windSpeed)*/

using System;

public class WindChillTemperature{
      public double CalculateWindChill(double temperature, double windSpeed){
            double windchill = 35.74 + 0.6215*temperature + (0.4275*temperature - 35.75) * Math.Pow(windSpeed,0.16);
            return windchill;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the temperature (in Fahrenheit): ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the wind speed (in miles per hour): ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            WindChillTemperature wct = new WindChillTemperature();
            double windChill = wct.CalculateWindChill(temperature,windSpeed);
            Console.WriteLine($"The wind chill temperature is: {windChill}"); 
      }
}
