using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Library_Management_System
{
		public class Magazine : LibraryItem, IReservable
		{
			private bool _isAvailable = true;

			public Magazine(int id, string title, string author)
				: base(id, title, author) { }

			public override int GetLoanDuration()
			{
				return 7; // 7 days
			}

			public void ReserveItem()
			{
				_isAvailable = false;
			}

			public bool CheckAvailability()
			{
				return _isAvailable;
			}
		}
	}


