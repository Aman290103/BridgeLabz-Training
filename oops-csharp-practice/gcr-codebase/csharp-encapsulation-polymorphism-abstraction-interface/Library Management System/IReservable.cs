using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Library_Management_System
{
	public interface IReservable
	{
		void ReserveItem();
		bool CheckAvailability();
	}
}
