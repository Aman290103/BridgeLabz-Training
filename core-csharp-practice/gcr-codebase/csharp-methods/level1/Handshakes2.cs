/*Create a program to find the maximum number of handshakes among N number of students.
Hint => 
Get integer input for numberOfStudents variable.
Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
Display the number of possible handshakes.
*/

using System;

public class HandShakes2{
      public static void possibleHandshakes(int n){
            int maxPossibleHandshakes = (n * (n - 1)) / 2;
            Console.WriteLine($"The maximum number of handshakes among {n} students is {maxPossibleHandshakes}");
      }

      public static void Main(String[] args){

            Console.WriteLine("Enter number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            possibleHandshakes(numberOfStudents);
      }
}