using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Patient_Management_System
{
    public abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        public int PatientId
        {
            get { return patientId; } 
            protected set { patientId = value; }
        }
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public int Age
        {
            get { return age; }
            protected set { age = value; }
        }

        protected Patient(int patientId,string name,int age) 
        { 
            this.PatientId = patientId ;
            this.Name = name ;
            this.Age = age;
        }

        public abstract void displayInfo();

    }
}
