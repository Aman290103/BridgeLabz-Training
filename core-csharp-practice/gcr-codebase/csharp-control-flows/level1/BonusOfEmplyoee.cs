/*Create a program to find the bonus of employees based on their years of service.
Hint => 
Zara decided to give a bonus of 5% to employees whose year of service is more than 5 years.
Take salary and year of service in the year as input.
Print the bonus amount.*/

using System;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter the salary of the employee: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the year of service of the employee: ");
        int yearOfService = Convert.ToInt32(Console.ReadLine());

        double bonus = 0.0;

        if (yearOfService > 5){
            bonus = salary * 0.05;
        }

        Console.WriteLine("The bonus amount is: " + bonus);
    }
}

