/*Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
Hint => 
Spring Season is from March 20 to June 20*/

using System;

public class SpringSeason
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter month and day: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        if (month == 3 && day >= 20 || month == 4 || month == 5 || month == 6 && day <= 20)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
