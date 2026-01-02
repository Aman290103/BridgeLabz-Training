/*Problem 2: Online Course Management
Design a Course class with:
Instance Variables: courseName, duration, fee.
Class Variable: instituteName (common for all courses).
Implement the following methods:
An instance method DisplayCourseDetails() to display course details.
A class method UpdateInstituteName() to modify the institute name for all courses.
*/

using System;

public class Course{
      public string courseName;
      public int duration;
      public int fee;
      public static string instituteName;

      public Course(string courseName,int duration,int fee){
        this.courseName=courseName;
        this.duration=duration;
        this.fee=fee;
      }

      public void DisplayCourseDetails(){
        Console.WriteLine("Course Name: "+courseName);
        Console.WriteLine("Course Duration: "+duration);
        Console.WriteLine("Course Fee: "+fee);
        Console.WriteLine("Institute Name: "+instituteName);
      }
      public static void UpdateInstituteName(string newInstituteName){
        instituteName=newInstituteName;
      }
}

public class Program{
      public static void Main(string[] args){
            Course.UpdateInstituteName("ABC Institute");
            Course c1=new Course("C#",6,5000);
            Course c2=new Course("Java",6,5000);
            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();
      }
}