/*and accountHolder.
Problem 4: Employee Records
Develop an Employee class with:
employeeID (public)
department (protected)
salary (private)
Implement methods to:
Modify salary using a public method.
Create a subclass Manager to access employeeID and department.
*/

using System;

public class Employee{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public void ModifySalary(double newSalary){
        salary = newSalary;
    }

    public double GetSalary(){
        return salary;
    }
}

public class Manager : Employee{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary)
    {
    }

    public void DisplayManagerInfo(){
        Console.WriteLine("Manager Employee ID: " + employeeID);
        Console.WriteLine("Manager Department: " + department);
    }
}

public class Program{
    public static void Main(string[] args){
        Employee employee = new Employee(1, "HR", 50000);
        Console.WriteLine("Employee ID: " + employee.employeeID);
        Console.WriteLine("Salary: " + employee.GetSalary());
        employee.ModifySalary(55000);
        Console.WriteLine("Modified Salary: " + employee.GetSalary());
        Manager manager = new Manager(2, "IT", 60000);
        manager.DisplayManagerInfo();
    }
}
