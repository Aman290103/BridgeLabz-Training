using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Health_check_pro
{
	public class LabController
	{
		[PublicApi("Get All Lab tests")]
		public void GetAllTests() { }

		[PublicApi("Get All Lab Tests by Id")]
		[RequiresAuth]
		public void GetTestsById() { }
		public void DeleteTest() { }
	}
}
