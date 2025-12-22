/*Create a program to count the number of digits in an integer.
Hint => 
Get an integer input for the number variable.
Create an integer variable count with value 0.
Use a loop to iterate until number is not equal to 0.
Remove the last digit from number in each iteration
Increase count by 1 in each iteration.
Finally display the count to show the number of digits*/

using System;

public class CountOfDigits{
    public static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
}
