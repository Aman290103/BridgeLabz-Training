/*Write a program to find the sum of numbers until the user enters 0
Hint => 
Create a variable total of type double initialize to 0.0. Also, create a variable to store the double value the user enters
Use the while loop to check if the user entered is 0
If the user entered value is not 0 then inside the while block add user entered value to the total and ask the user to input again
The loop will continue till the user enters zero and outside the loop display the total value*/

using System;

public class SumOfNumbers {
    public static void Main(string[] args){
        
        double sum = 0.0;
        double num;
        
        Console.Write("Enter a number : ");
        num = Convert.ToDouble(Console.ReadLine());
        
        while (num != 0)
        {
            sum += num;
            Console.Write("Enter a number : ");
            num = Convert.ToDouble(Console.ReadLine());
        }
        
        Console.WriteLine($"The sum of the numbers is: {sum}" );
    }
}

