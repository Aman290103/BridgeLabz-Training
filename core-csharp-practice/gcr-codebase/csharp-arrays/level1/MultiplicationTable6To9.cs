/*Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result
Hint => 
Take integer input and store it in the variable number as well as define an integer array to store the multiplication result in the variable multiplicationResult
Using a for loop, find the multiplication table of numbers from 6 to 9 and save the result in the array
Finally, display the result from the array in the format number * i = ___*/

using System;

public class Program{
    public static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        int[] multiplicationResult = new int[4];
        for (int i = 6; i <= 9; i++){
            multiplicationResult[i - 6] = number * i;
        }
        for (int i = 0; i < 4; i++){
            Console.WriteLine($"{number} * {(i + 6)} = {multiplicationResult[i]}");
        }
    }
}
