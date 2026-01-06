using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Patient_Management_System
{
    public class OutPatient : Patient , IPayable
    {
        private double consultationFees;

        public OutPatient(int id , string name ,int age, double fees): base(id,name,age)
        {
            this.consultationFees = fees;
        }
        public double CalculateBill()
        {
            return consultationFees;
        }

        public override void displayInfo()
        {
            Console.WriteLine("Out-Patient Details");
            Console.WriteLine($"Id : {PatientId}, Name : {Name}, Age : {Age}");
            Console.WriteLine($"Total Bill : {CalculateBill()}");
        }


    }
    
}
