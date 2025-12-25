/*  Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the total, average, and the percentage score 

Hint => 
a.Take input for the number of students
b.Write a method to generate random 2-digit scores for Physics, Chemistry, and Math (PCM) for the students and return the scores. This method returns a 2D array with PCM scores for all students
c.Write a Method to calculate the total, average, and percentages for each student and return a 2D array with the corresponding values. Please ensure to round off the values to 2 Digits using the Math.Round() method. 
d.Finally, write a Method to display the scorecard of all students with their scores, total, average, and percentage in a tabular for
*/

using System;     

public class PercentageAndGradeOfStudent{
      public static int[,] GenerateScores(int studentCount){
            Random random = new Random();
            int[,] scores = new int[studentCount, 3];

            for(int i=0; i<studentCount; i++){
                  scores[i, 0] = random.Next(10, 100); // Physics
                  scores[i, 1] = random.Next(10, 100); // Chemistry
                  scores[i, 2] = random.Next(10, 100); // Math
            }
            return scores;
      }

      public static double[,] CalculateResults(int[,] scores, int studentCount){
            double[,] results = new double[studentCount, 3];

            for(int i=0; i<studentCount; i++){
                  int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                  double average = total / 3.0;
                  double percentage = (total / 300.0) * 100;

                  results[i, 0] = Math.Round(total, 2);
                  results[i, 1] = Math.Round(average, 2);
                  results[i, 2] = Math.Round(percentage, 2);
            }
            return results;
      }
      public static void DisplayScorecard(int[,] scores, double[,] results, int studentCount){
            Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

            for(int i=0; i<studentCount; i++){
                  Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
            }
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the number of students:");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            int[,] scores = GenerateScores(studentCount);
            double[,] results = CalculateResults(scores, studentCount);
            DisplayScorecard(scores, results, studentCount);
      }
}