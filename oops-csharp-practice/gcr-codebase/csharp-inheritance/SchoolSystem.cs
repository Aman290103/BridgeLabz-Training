/*School System with Different Roles
Description: Create a hierarchy for a school system where Person is the superclass, and Teacher, Student, and Staff are subclasses.
Tasks:
Define a superclass Person with common attributes like Name and Age.
Define subclasses Teacher, Student, and Staff with specific attributes (e.g., Subject for Teacher and Grade for Student).
Each subclass should have a method like DisplayRole() that describes the role.
Goal: Demonstrate hierarchical inheritance by modeling different roles in a school, each with shared and unique characteristics.
*/

using System;

class Person{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age){
        this.Name = name;
        this.Age = age;
    }
}
class Teacher : Person{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject) : base(name, age){
        this.Subject = subject;
    }
    public void DisplayRole(){
        Console.WriteLine($"Teacher: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
class Student : Person{
    public int Grade { get; set; }
    public Student(string name, int age, int grade) : base(name, age){
        this.Grade = grade;
    }
    public void DisplayRole(){
        Console.WriteLine($"Student: {Name}, Age: {Age}, Grade: {Grade}");
    }
}
class Staff : Person{
    public string Department { get; set; }
    public Staff(string name, int age, string department) : base(name, age){
        this.Department = department;
    }
    public void DisplayRole(){
        Console.WriteLine($"Staff: {Name}, Age: {Age}, Department: {Department}");
    }
}
class SchoolSystem{
    public static void Main(string[] args){
        Teacher teacher = new Teacher("Mr. Smith", 35, "Math");
        Student student = new Student("John Doe", 15, 10);
        Staff staff = new Staff("Mrs. Johnson", 28, "Administration");

        teacher.DisplayRole();
        student.DisplayRole();
        staff.DisplayRole();
    }
}

