/*Educational Course Hierarchy
Description: Model a course system where Course is the base class, OnlineCourse is a subclass, and PaidOnlineCourse extends OnlineCourse.
Tasks:
Define a superclass Course with attributes like CourseName and Duration.
Define OnlineCourse to add attributes such as Platform and IsRecorded.
Define PaidOnlineCourse to add Fee and Discount.
Goal: Demonstrate how each level of inheritance builds on the previous, adding complexity to the system.
*/

using System;

class Course{
    public string CourseName;
    public int Duration;
    public Course(string courseName, int duration){
        this.CourseName = courseName;
        this.Duration = duration;
    }
}
class OnlineCourse : Course{
    public string Platform;
    public bool IsRecorded;
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration){
        this.Platform = platform;
        this.IsRecorded = isRecorded;
    }
}     
class PaidOnlineCourse : OnlineCourse{
    public double Fee;
    public double Discount; 
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded){
        this.Fee = fee;
        this.Discount = discount;
    }
}     
class EducationCourseHiearchy{
    public static void Main(){
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("C#", 30, "Udemy", true, 1000.0, 10.0);
        Console.WriteLine($"Course Name: {paidCourse.CourseName}");
        Console.WriteLine($"Duration: {paidCourse.Duration} weeks");
        Console.WriteLine($"Platform: {paidCourse.Platform}");
        Console.WriteLine($"Is Recorded: {paidCourse.IsRecorded}");
        Console.WriteLine($"Fee: ${paidCourse.Fee}");
        Console.WriteLine($"Discount: {paidCourse.Discount}%");
    }
}
