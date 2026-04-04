/*Write a program to take user input for 5 numbers and check whether a number is positive,  negative, or zero. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they equal, greater or less
Hint => 
Define an integer array of 5 elements and get user input to store in the array.
Loop through the array using the length If the number is positive, check for even or odd numbers and print accordingly
If the number is negative, print negative. Else if the number is zero, print zero. 
Finally compare the first and last element of the array and display if they equal, greater or less*/

using System;

public class positiveNegativeOrZero{
    public static void Main(string[] args){
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++){
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] > 0){
                if (numbers[i] % 2 == 0){
                    Console.WriteLine("The number is positive and even.");
                }
                else{
                    Console.WriteLine("The number is positive and odd.");
                }
            }
            else if (numbers[i] < 0){
                Console.WriteLine("The number is negative.");
            }
            else{
                Console.WriteLine("The number is zero.");
            }
        }

        if (numbers[0] == numbers[4])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}

