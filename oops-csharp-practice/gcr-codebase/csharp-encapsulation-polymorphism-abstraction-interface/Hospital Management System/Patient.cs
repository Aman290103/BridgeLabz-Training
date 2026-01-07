using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Management_System
{
		public abstract class Patient
		{
			private int _patientId;
			private string _name;
			private int _age;

			// Sensitive data (encapsulation)
			private string _diagnosis;
			private string _medicalHistory;

			protected Patient(int patientId, string name, int age)
			{
				_patientId = patientId;
				_name = name;
				_age = age;
			}

			public int PatientId
			{
				get { return _patientId; }
				protected set { _patientId = value; }
			}

			public string Name
			{
				get { return _name; }
				protected set { _name = value; }
			}

			public int Age
			{
				get { return _age; }
				protected set { _age = value; }
			}

			// Protected methods to secure sensitive data
			protected void SetMedicalDetails(string diagnosis, string history)
			{
				_diagnosis = diagnosis;
				_medicalHistory = history;
			}

			protected void ShowMedicalDetails()
			{
				Console.WriteLine("Diagnosis: " + _diagnosis);
				Console.WriteLine("Medical History: " + _medicalHistory);
			}

			public string GetPatientDetails()
			{
				return $"ID: {_patientId}, Name: {_name}, Age: {_age}";
			}

			public abstract double CalculateBill();
		}
	}
