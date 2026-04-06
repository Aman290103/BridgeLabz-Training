
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Management_System
{
		public class OutPatient : Patient, IMedicalRecord
		{
			private double _consultationFee;

			public OutPatient(int id, string name, int age, double consultationFee)
				: base(id, name, age)
			{
				_consultationFee = consultationFee;
			}

			public override double CalculateBill()
			{
				return _consultationFee;
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

