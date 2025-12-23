/*Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 

Hint => 
Take input for the number of students
Create arrays to store marks, percentages, and grades of the students
Take input for marks of students in physics, chemistry, and maths. If the marks are negative, ask the user to enter positive values and decrement the index
Calculate the percentage and grade of the students based on the percentage
Display the marks, percentages, and grades of each student
*/

using System;

public class StudentGradeCalculator{
    public static void Main(string[] args){
       
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[n, 3];          
        double[] percentages = new double[n];
        char[] grades = new char[n];

        for (int i = 0; i < n; i++){
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            for (int j = 0; j < 3; j++){
                string subject;
            if (j == 0) {
            subject = "Physics";
            } 
            else if (j == 1) {
                  subject = "Chemistry";
            } else {
                  subject = "Maths";
            }                
            
            Console.Write($"{subject}: ");
            int mark = Convert.ToInt32(Console.ReadLine());

                // If negative marks, re-enter
            if (mark < 0){
                  Console.WriteLine("Marks cannot be negative. Please re-enter.");
                  j--; // decrement index to retry
                  continue;
            }

            marks[i, j] = mark;
            
            }

            // Calculate percentage
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = total / 3.0;

            // Calculate grade
            if (percentages[i] >= 80){
                grades[i] = 'A';
            }
            else if (percentages[i] >= 70){
                grades[i] = 'B';
            }
            else if (percentages[i] >= 60){
                grades[i] = 'C';
            }
            else if (percentages[i] >= 50){
                grades[i] = 'D';
            }
            else if (percentages[i] >= 40){
                grades[i] = 'E';
            }
            else{
                grades[i] = 'R';
            }
        }

        Console.WriteLine("\nStudent Results");
        for (int i = 0; i < n; i++){
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.WriteLine($"Physics: {marks[i, 0]}, Chemistry: {marks[i, 1]}, Maths: {marks[i, 2]}");
            Console.WriteLine($"Percentage: {percentages[i]:F2}%");
            Console.WriteLine($"Grade: {grades[i]}");
        }
    }
}
