/*Create a program to find the BMI of a person
Hint => 
Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding variable.
Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
Use the table to determine the weight status of the person*/

using System;

public class BMI{
    public static void Main(string[] args){

        Console.WriteLine("Enter the weight in kg");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height in cm");
        double height = Convert.ToDouble(Console.ReadLine());

        height = height / 100;
        double bmi = weight / (height * height);

        Console.WriteLine($"BMI is {bmi}");
        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}

