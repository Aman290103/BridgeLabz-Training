using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Hospital_Management_System
{
	public interface IMedicalRecord
	{
		void AddRecord(string diagnosis, string history);
		void ViewRecords();
	}
}
