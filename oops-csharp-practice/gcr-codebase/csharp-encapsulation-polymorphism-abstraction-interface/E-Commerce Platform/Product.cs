namespace BridgeLabz.E_Commerce_Platform
{
	public abstract class Product
	{
		private int _productId;
		private string _name;
		private double _price;

		protected Product(int productId, string name, double price)
		{
			_productId = productId;
			_name = name;
			_price = price;
		}

		public int ProductId
		{
			get { return _productId; }
			protected set { _productId = value; }
		}

		public string Name
		{
			get { return _name; }
			protected set { _name = value; }
		}

		public double Price
		{
			get { return _price; }
			protected set
			{
				if (value > 0)
					_price = value;
			}
		}

		public abstract double CalculateDiscount();
	}
}
