using System;

namespace BridgeLabz.Hospital_Patient_Management_System
{
	public class PatientManagement
	{
		static void Main(string[] args)
		{
			Patient inPatient = new InPatient(
				id: 101,
				name: "John",
				age: 45,
				days: 5,
				charge: 2000
			);
			Patient outPatient = new OutPatient(
				id: 102,
				name: "Mary",
				age: 30,
				fees: 500
			);

			Console.WriteLine("---- Hospital Patient Management System ----\n");

			
			inPatient.displayInfo();
			Console.WriteLine();

			outPatient.displayInfo();
			Console.WriteLine();

			// Interface reference demonstration
			IPayable bill1 = (IPayable)inPatient;
			IPayable bill2 = (IPayable)outPatient;

			Console.WriteLine("---- Billing Section ----");
			Console.WriteLine($"In-Patient Bill Amount : {bill1.CalculateBill()}");
			Console.WriteLine($"Out-Patient Bill Amount : {bill2.CalculateBill()}");

			Console.ReadLine();
		}
	}
}
