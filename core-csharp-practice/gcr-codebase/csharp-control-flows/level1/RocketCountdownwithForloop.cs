/*Write a program to count down the number from the user input value to 1 using a for loop for a rocket launch
Hint => 
Create a variable counter to take user inputted value for the countdown.
Use the for loop to check if the counter is 1
Inside a for loop, print the value of the counter and decrement the counter.*/

using System;

public class RocketCountdownwithForloop{
    public static void Main(string[] args){

      Console.WriteLine("Enter the number to start the countdown: ");
      int counter = Convert.ToInt32(Console.ReadLine());

      for (int i = counter; i >= 1; i--){
            Console.WriteLine(i);
      }
    }
}