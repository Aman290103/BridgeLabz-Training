/*5.Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights

Hint => 
Take user input for the age and height of the 3 friends and store it in a variable
Find the smallest of the 3 ages to find the youngest friend and display it
Find the largest of the 3 heights to find the tallest friend and display it*/

using System;

public class YoungestFriend{
    public static void Main(string[] args){
      
        Console.WriteLine("Enter Amar's age:");
        int amarAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Amar's height (in cm):");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age:");
        int akbarAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's height (in cm):");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age:");
        int anthonyAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's height (in cm):");
        int anthonyHeight = int.Parse(Console.ReadLine());

        int youngestAge = amarAge;

        if (akbarAge < youngestAge)
            youngestAge = akbarAge;
        if (anthonyAge < youngestAge)
            youngestAge = anthonyAge;

        int tallestHeight = amarHeight;

        if (akbarHeight > tallestHeight)
            tallestHeight = akbarHeight;
        if (anthonyHeight > tallestHeight)
            tallestHeight = anthonyHeight;

        Console.WriteLine($"The youngest friend is {youngestAge} years old.");
        Console.WriteLine($"The tallest friend is {tallestHeight} cm tall.");
    }
}

