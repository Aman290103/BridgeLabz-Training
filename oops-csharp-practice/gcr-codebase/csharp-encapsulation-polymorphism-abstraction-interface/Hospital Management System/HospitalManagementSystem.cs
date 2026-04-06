using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Management_System
{
		class HospitalManagementSystem
	{
			public static void Main()
			{
				Patient p1 = new InPatient(1, "Rahul", 45, 5, 3000);
				Patient p2 = new OutPatient(2, "Anita", 30, 800);

				ProcessPatient(p1);
				ProcessPatient(p2);
			}

			static void ProcessPatient(Patient patient)
			{
				Console.WriteLine(patient.GetPatientDetails());

				if (patient is IMedicalRecord record)
				{
					record.AddRecord("General Checkup", "No major illness");
					record.ViewRecords();
				}

				Console.WriteLine("Total Bill: " + patient.CalculateBill());
				Console.WriteLine("----------------------------------");
			}
		}
	}


