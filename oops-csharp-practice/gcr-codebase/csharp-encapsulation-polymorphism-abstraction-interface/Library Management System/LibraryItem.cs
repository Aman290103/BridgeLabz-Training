using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Library_Management_System
{
		public abstract class LibraryItem
		{
			private int _itemId;
			private string _title;
			private string _author;

			// Sensitive data (encapsulation)
			private string _borrowerName;

			protected LibraryItem(int itemId, string title, string author)
			{
				_itemId = itemId;
				_title = title;
				_author = author;
			}

			public int ItemId
			{
				get { return _itemId; }
				protected set { _itemId = value; }
			}

			public string Title
			{
				get { return _title; }
				protected set { _title = value; }
			}

			public string Author
			{
				get { return _author; }
				protected set { _author = value; }
			}

			// Borrower details secured
			protected void SetBorrower(string borrowerName)
			{
				_borrowerName = borrowerName;
			}

			public string GetItemDetails()
			{
				return $"ID: {_itemId}, Title: {_title}, Author: {_author}";
			}

			public abstract int GetLoanDuration();
		
	}

}
