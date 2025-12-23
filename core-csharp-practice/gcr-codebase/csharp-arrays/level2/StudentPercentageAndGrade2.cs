/*Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
Hint => 
All the steps are the same as the problem 8 except the marks are stored in a 2D array
Use the 2D array to calculate the percentages, and grades of the students
*/

using System;

public class PercentageAndGrade{
    public static void Main(string[] args){
        int[,] marks = new int[3, 3];
        for (int i = 0; i < 3; i++){
            Console.WriteLine("Enter the marks of student " + (i + 1));
            for (int j = 0; j < 3; j++){
                Console.Write("Enter the marks of subject " + (j + 1) + ": ");
                marks[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++){
            int total = 0;
            for (int j = 0; j < 3; j++){
                total += marks[i, j];
            }
            double percentage = (double)total / 3;
            Console.WriteLine("Percentage of student " + (i + 1) + ": " + percentage);
            if (percentage >= 90){
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80){
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 70){
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 60){
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 40){
                Console.WriteLine("Grade: E");
            }
            else{
                Console.WriteLine("Grade: F");
            }
        }
    }
}
