/*7. Create a program to swap two numbers
Hint:
Create a variable number1 and take user input.
Create a variable number2 and take user input.
Swap number1 and number2 and print the swapped output.
I/P => number1, number2
O/P => The swapped numbers are ___ and ___*/

using System;

public class SwappingTwoNumbers{
    public static void Main(string[] args){
        
        Console.WriteLine("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}

