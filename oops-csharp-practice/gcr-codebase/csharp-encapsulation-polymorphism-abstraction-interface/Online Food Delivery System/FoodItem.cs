using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Online_Food_Delivery_System
{
		public abstract class FoodItem
		{
			private string _itemName;
			private double _price;
			private int _quantity;

			protected FoodItem(string itemName, double price, int quantity)
			{
				_itemName = itemName;
				_price = price;
				_quantity = quantity;
			}

			public string ItemName
			{
				get { return _itemName; }
				protected set { _itemName = value; }
			}

			public double Price
			{
				get { return _price; }
				protected set { _price = value; }
			}

			public int Quantity
			{
				get { return _quantity; }
				protected set { _quantity = value; }
			}

			public string GetItemDetails()
			{
				return $"Item: {_itemName}, Price: {_price}, Quantity: {_quantity}";
			}

			public abstract double CalculateTotalPrice();
		}
	}


