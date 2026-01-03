/*Sample Program 3: Employee Management System
Design an Employee class with the following features:
static: 
A static variable CompanyName shared by all employees.
A static method DisplayTotalEmployees() to show the total number of employees.
this: 
Use this to initialize Name, Id, and Designation in the constructor.
readonly: 
Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
is operator: 
Check if a given object is an instance of the Employee class before printing the employee details.
*/

using System;

public class Employee{
    public static string CompanyName { get; set; }
    public static int TotalEmployees { get; private set; }
    public readonly int Id ;
    public string Name { get; }
    public string Designation { get; }

    public Employee(string name, int id, string designation){
        Name = name;
        Id = id;
        Designation = designation;
        TotalEmployees++;
    }

    static Employee(){
        CompanyName = "Capegemini";
    }

    public static void DisplayTotalEmployees(){
        Console.WriteLine($"Total Employees: {TotalEmployees}");
    }

    public void PrintDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Company: {CompanyName}");
    }
}
public class Program{
    public static void Main(string[] args){
        Employee emp1 = new Employee("John Doe", 1, "Developer");
        Employee emp2 = new Employee("Jane Smith", 2, "Manager");

        if (emp1 is Employee){
            emp1.PrintDetails();
            Console.WriteLine();
        }

        if (emp2 is Employee){
            emp2.PrintDetails();
            Console.WriteLine();
        }

        Employee.DisplayTotalEmployees();
    }
}
