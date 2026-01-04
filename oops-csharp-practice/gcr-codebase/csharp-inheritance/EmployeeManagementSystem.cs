/* Employee Management System
Description:
Create an Employee hierarchy for different employee types such as Manager, Developer, and Intern.
Tasks:
Define a base class Employee:
Add three attributes: Name (string), Id (integer), and Salary (double).
Add a method DisplayDetails() to display the details of an employee.
Define subclasses Manager, Developer, and Intern:
Manager: Add an additional attribute TeamSize (integer).
Developer: Add an additional attribute ProgrammingLanguage (string).
Intern: Add an additional attribute InternshipDuration (string).
Goal:
Practice inheritance by creating subclasses with specific attributes and overriding superclass methods (e.g., DisplayDetails()) to display details specific to each type of employee*/

using System;

class Employee{
    public string Name;
    public int Id;
    public double Salary;
    public Employee(string name, int id, double salary){
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }
    public virtual void DisplayDetails(){
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}
class Manager : Employee{
    public int TeamSize;
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary){
        TeamSize = teamSize;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}
class Developer : Employee{
    public string ProgrammingLanguage;
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary){
        ProgrammingLanguage = programmingLanguage;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}
class Intern : Employee{
    public string InternshipDuration;
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary){
        InternshipDuration = internshipDuration;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {InternshipDuration}");
    }
}
class EmployeeManagementSystem{
    static void Main(string[] args){
        Manager manager = new Manager("John Doe", 101, 50000, 10);
        Developer developer = new Developer("Jane Smith", 102, 60000, "C#");
        Intern intern = new Intern("Bob Johnson", 103, 30000, "6 months");

        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}
