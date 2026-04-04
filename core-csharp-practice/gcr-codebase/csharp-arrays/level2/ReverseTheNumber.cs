/*Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
Hint => 
Take user input for a number. 
Find the count of digits in the number. 
Find the digits in the number and save them in an array
Create an array to store the elements of the digits array in reverse order
Finally, display the elements of the array in reverse order  
*/

using System;

public class Program{
    public static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = (int)Math.Floor(Math.Log10(number) + 1);
        int[] digits = new int[digitCount];

        for (int i = 0; i < digitCount; i++){
            digits[i] = number % 10;
            number /= 10;
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < digitCount; i++){
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
