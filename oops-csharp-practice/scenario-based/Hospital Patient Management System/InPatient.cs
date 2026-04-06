using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Patient_Management_System
{
    public class InPatient : Patient , IPayable
    {
        private int daysAdmitted;
        private double dailyCharge;

		public InPatient(int id, string name, int age, int days, double charge) : base(id, name, age)
		{
			this.daysAdmitted = days;
			this.dailyCharge = charge;
		}

		public double CalculateBill()
		{
			return daysAdmitted*dailyCharge;
		}

		public override void displayInfo()
		{
            Console.WriteLine("In-Patient Details");
            Console.WriteLine($"Id : {PatientId}, Name : {Name}, Age : {Age}");
			Console.WriteLine($"Total Bill : {CalculateBill()}");
		}
	}
}
