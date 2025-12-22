/*Write a program to input marks and 3 subjects physics, chemistry and maths. Compute the percentage and then calculate the grade as per the following guidelines 

Hint => 
Ensure the Output clearly shows the Average Mark as well as the Grade and Remarks*/

using System;

class StudentGradeCalculator{
    public static void Main(){
    
        Console.Write("Enter Physics marks: ");
        double physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        double maths = Convert.ToDouble(Console.ReadLine());

        // Calculate average (percentage)
        double average = (physics + chemistry + maths) / 3;

        string grade;
        string remarks;

        // Determine grade and remarks
        if (average >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (average >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (average >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching standards";
        }
        else if (average >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below standards";
        }
        else if (average >= 40)
        {
            grade = "E";
            remarks = "Level 1, too below standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Output
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Average Marks : " + average);
        Console.WriteLine("Grade         : " + grade);
        Console.WriteLine("Remarks       : " + remarks);
    }
}
