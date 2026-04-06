using System;
namespace BridgeLabz.EmployeeManagementSystem
{

	public class FullTimeEmployee : Employee, IDepartment
	{
		private string department;
		public FullTimeEmployee(int id, string name, decimal fixedSalary)
			: base(id, name, fixedSalary) { }
		public override decimal CalculateSalary()
		{
			return BaseSalary;
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
