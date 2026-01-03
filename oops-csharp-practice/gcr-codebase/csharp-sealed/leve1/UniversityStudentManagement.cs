/*Sample Program 5: University Student Management
Create a Student class to manage student data with the following features:
static: 
A static variable UniversityName shared across all students.
A static method DisplayTotalStudents() to show the number of students enrolled.
this: 
Use this in the constructor to initialize Name, RollNumber, and Grade.
readonly: 
Use a readonly variable RollNumber for each student that cannot be changed.
is operator: 
Check if a given object is an instance of the Student class before performing operations like displaying or updating grades.
*/

using System;

public class Student{
      public static string UniversityName;
      public string Name;
      public readonly int RollNumber;
      public string Grade;
      public static int TotalStudents;

      static Student(){
            UniversityName = "GLA University";
      }

      public Student(string name, int rollNumber, string grade){
            Name = name;
            RollNumber = rollNumber;
            Grade = grade;
            TotalStudents++;
      }
      public static void DisplayTotalStudents(){
            Console.WriteLine("Total Students: " + TotalStudents);
      }
      public void gradeUpdate(string newGrade){
            if(this is Student){
                  Grade = newGrade;
            }
            else{
                  Console.WriteLine("Operation not permitted");
            }
      }
      public void DisplayInfo(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
      }
}
public class Program{
      public static void Main(string[] args){
            Student student1 = new Student("John", 101, "A");
            Student student2 = new Student("Alice", 102, "B");
            Console.WriteLine("University Name: " + Student.UniversityName);
            Student.DisplayTotalStudents();
            student1.DisplayInfo();
            student2.DisplayInfo();
            student1.gradeUpdate("A+");
            student1.DisplayInfo();
      }
}