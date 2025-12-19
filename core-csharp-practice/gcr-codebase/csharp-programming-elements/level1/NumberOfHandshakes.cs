/*16. Create a program to find the maximum number of handshakes among N number of
students.
Hint:
Get integer input for numberOfStudents variable.
Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible
handshakes.
Display the number of possible handshakes.*/

using System;

public class MaximumHandshakes{

    public static void Main(string[] args){
        
        Console.WriteLine("Enter the number of students: ");
        
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine(maxHandshakes);
    }
}
