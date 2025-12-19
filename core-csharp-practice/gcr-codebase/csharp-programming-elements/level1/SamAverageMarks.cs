/*2. Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the
*average percent mark in PCM
*I/P => NONE
*O/P => Sam’s average mark in PCM is ___*/

using System;

public class SamAverageMarks{
      public static void Main(string[] args){
            int samMaths = 94;
            int samPhysics = 95;
            int samChemistry = 96;
            int totalMarks = 300;
            int samTotal = samMaths + samPhysics + samChemistry;
            int samAverage = samTotal / 3;
            Console.WriteLine($"Sam's average mark in PCM is {samAverage}");
      }
}