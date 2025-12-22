/*.Create a program to find all the multiple of a number taken as user input below 100.
Hint => 
Get input value for a variable named number.
Run a for loop backward: from i = 100 to i = 1.
Inside the loop, check if i perfectly divide the number.
If true, print the number and continue the loop.*/

using System;

public class Multiples{
    public static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
                Console.WriteLine(i);
            }
        }
    }
}


