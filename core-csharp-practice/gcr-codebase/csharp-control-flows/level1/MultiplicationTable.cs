/*Create a program to find the multiplication table of a number entered by the user from 6 to 9.
Hint => 
Take integer input and store it in the variable number
Using a for loop, find the multiplication table of number from 6 to 9 and print it in the format number * i = ___ */

using System;

public class Table{
    public static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 6; i <= 9; i++){
            Console.WriteLine($"{number} * {i} = {number} * {i}");
        }
    }
}


