/*Create a program to print a multiplication table of a number.
Hint => 
Get an integer input and store it in the number variable. Also, define a integer array to store the results of multiplication from 1 to 10
Run a loop from 1 to 10 and store the results in the multiplication table array
Finally, display the result from the array in the format number * i = ___*/

using System;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] multiplicationTable = new int[10];
        for (int i = 1; i <= 10; i++){
            multiplicationTable[i - 1] = number * i;
        }
        for (int i = 1; i <= 10; i++){
            Console.WriteLine($"{number} * {i} = {multiplicationTable[i - 1]}");
        }
    }
}
