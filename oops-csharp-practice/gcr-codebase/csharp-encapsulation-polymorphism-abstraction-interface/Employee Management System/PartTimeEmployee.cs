using System;
namespace BridgeLabz.EmployeeManagementSystem
{
	public class PartTimeEmployee : Employee, IDepartment
	{
		private int hoursWorked;
		private decimal hourlyRate;
		private string department;

		public PartTimeEmployee(int id, string name, int hoursWorked, decimal hourlyRate)
			: base(id, name, 0)
		{
			this.hoursWorked = hoursWorked;
			this.hourlyRate = hourlyRate;
		}
		public override decimal CalculateSalary()
		{
			return hoursWorked * hourlyRate;
		}
		public void AssignDepartment(string departmentName)
		{
			department = departmentName;
		}
		public string GetDepartmentDetails()
		{
			return department;
		}
	}
}
