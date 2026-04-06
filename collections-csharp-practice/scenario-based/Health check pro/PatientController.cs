using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Health_check_pro
{
	public class PatientController
	{
		[PublicApi("Register User")]
		public void RegisterUser() { }

		[RequiresAuth]
		public void ViewPatientHistory() { }
	}
}
