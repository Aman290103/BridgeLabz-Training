using System;

namespace BridgeLabz.EmployeeManagementSystem{
	public abstract class Employee{
		private int employeeId;
		private string name;
		private decimal baseSalary;
		public int EmployeeId{
			get {return employeeId;}
			protected set {employeeId = value;}
		}
		public string Name{
			get {return name;}
			protected set {name = value;}
		}
		public decimal BaseSalary{
			get {return baseSalary};
			protected set
			{
				if (value < 0)
					throw new ArgumentException("Salary cannot be negative.");
				baseSalary = value;
			}
		}
		protected Employee(int employeeId, string name, decimal baseSalary)
		{
			this.EmployeeId = employeeId;
			this.Name = name;
			this.BaseSalary = baseSalary;
		}
		public abstract decimal CalculateSalary();
		public virtual void DisplayDetails()
		{
			Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}");
		}
	}

}