/*13. Write a program to find the side of the square whose perimeter you read from user
Hint: Perimeter of Square is 4 times side
I/P => perimeter
O/P => The length of the side is ___ whose perimeter is ____*/

using System;

public class SideOfSquare
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the perimeter of the square:");
        int perimeter = Convert.ToInt32(Console.ReadLine());

        int side = perimeter / 4;

        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
}
