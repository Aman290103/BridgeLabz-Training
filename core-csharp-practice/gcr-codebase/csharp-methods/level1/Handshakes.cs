/*Create a program to find the maximum number of handshakes among N number of students.
Hint => 
Get integer input for number of students
Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
Write a method to use the combination formulae to calculate the number of handshakes*/

using System;

public class handshakes{
      public static int numberOfHandshaked(int n){
            int maxHandshakes = (n * (n - 1)) / 2;
            return maxHandshakes;
      }

      public static void Main(string[] args){

            Console.WriteLine("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int maxHandshakes = numberOfHandshaked(n);
            Console.WriteLine($"The maximum number of handshakes among {n} students is {maxHandshakes}"); 
      }
}
