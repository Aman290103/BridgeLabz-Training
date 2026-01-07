using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Library_Management_System
{
		public class Book : LibraryItem, IReservable
		{
			private bool _isAvailable = true;

			public Book(int id, string title, string author)
				: base(id, title, author) { }

			public override int GetLoanDuration()
			{
				return 14; // 14 days
			}

			public void ReserveItem()
			{
				if (_isAvailable)
				{
					_isAvailable = false;
					SetBorrower("Reserved Member");
				}
			}

			public bool CheckAvailability()
			{
				return _isAvailable;
			}
		}
	}


