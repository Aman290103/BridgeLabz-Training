namespace BridgeLabz.E_Commerce_Platform
{
	public class Clothing : Product, ITaxable
	{
		public Clothing(int id, string name, double price)
			: base(id, name, price) { }

		public override double CalculateDiscount()
		{
			return Price * 0.20; // 20% discount
		}

		public double CalculateTax()
		{
			return Price * 0.12; // 12% GST
		}

		public string GetTaxDetails()
		{
			return "Clothing Tax: 12% GST";
		}
	}
}
