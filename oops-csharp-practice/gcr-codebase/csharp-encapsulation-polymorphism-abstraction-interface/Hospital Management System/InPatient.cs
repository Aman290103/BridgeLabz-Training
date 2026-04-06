using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Management_System
{
		public class InPatient : Patient, IMedicalRecord
		{
			private int _daysAdmitted;
			private double _dailyCharge;

			public InPatient(int id, string name, int age, int days, double dailyCharge)
				: base(id, name, age)
			{
				_daysAdmitted = days;
				_dailyCharge = dailyCharge;
			}

			public override double CalculateBill()
			{
				return _daysAdmitted * _dailyCharge + 2000; // room & service charges
			}

			public void AddRecord(string diagnosis, string history)
			{
				SetMedicalDetails(diagnosis, history);
			}

			public void ViewRecords()
			{
				ShowMedicalDetails();
			}
		}
	}


