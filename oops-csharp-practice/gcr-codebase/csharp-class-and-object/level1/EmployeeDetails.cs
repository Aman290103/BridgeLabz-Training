/*Program to Display Employee Details
Problem Statement: Write a program to create an Employee class with attributes name, id, and salary. Add a method to display the details.
*/

using System;

using System;

class Employee{
    public string Name = "Aman";
    public int Id=1234;
    public double Salary=1234;

    
    public void DisplayDetails(){
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("ID     : " + Id);
        Console.WriteLine("Salary : " + Salary);
    }
}

public class EmployeeDetails{
    public static void Main(string[] args){
        Employee emp = new Employee();
        emp.DisplayDetails();
    }
}
