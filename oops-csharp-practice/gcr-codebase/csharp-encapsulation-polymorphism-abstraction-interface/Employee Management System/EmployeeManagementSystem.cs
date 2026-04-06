using System;
namespace BridgeLabz.EmployeeManagementSystem
{

	class Program
	{
		static void Main()
		{
			Employee emp1 = new FullTimeEmployee(1, "Alice", 50000);
			Employee emp2 = new PartTimeEmployee(2, "Bob", 120, 25);

			emp1.DisplayDetails();   // Calls FullTimeEmployee.CalculateSalary()
			emp2.DisplayDetails();   // Calls PartTimeEmployee.CalculateSalary()

			IDepartment dept1 = (IDepartment)emp1;
			IDepartment dept2 = (IDepartment)emp2;

			dept1.AssignDepartment("HR");
			dept2.AssignDepartment("IT");

			Console.WriteLine($"Department: {dept1.GetDepartmentDetails()}");
			Console.WriteLine($"Department: {dept2.GetDepartmentDetails()}");
		}
	}
}


