/*2. Access Modifiers
Problem 1: University Management System
Create a Student class with:
rollNumber (public)
name (protected)
CGPA (private)
Implement methods to:
Access and modify CGPA using public methods.
Create a subclass PostgraduateStudent to demonstrate the use of protected members.
*/

using System;

public class Student{
    public int rollNumber;
    protected string name;
    private double CGPA;

    public Student(int rollNumber, string name, double CGPA){
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public setter
    public void SetCGPA(double cgpa){
        this.CGPA = cgpa;
    }

    // Public getter
    public double GetCGPA(){
        return this.CGPA;
    }
}

public class PostgraduateStudent : Student{
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA){}
    
    // Method to access protected member
    public void DisplayName(){
        Console.WriteLine("Postgraduate Student Name: " + name);
    }
}
public class UniversityManagementSystem{
    public static void Main(string[] args){
        Student student = new Student(183, "Aman", 7.58);

        student.SetCGPA(8.0);
        Console.WriteLine("CGPA: " + student.GetCGPA());

        PostgraduateStudent pgStudent = new PostgraduateStudent(1264, "Prakhar", 3.2);

        pgStudent.DisplayName();
    }
}
