namespace BridgeLabz.E_Commerce_Platform
{
	public class Electronics : Product, ITaxable
	{
		public Electronics(int id, string name, double price)
			: base(id, name, price) { }

		public override double CalculateDiscount()
		{
			return Price * 0.10; // 10% discount
		}

		public double CalculateTax()
		{
			return Price * 0.18; // 18% GST
		}

		public string GetTaxDetails()
		{
			return "Electronics Tax: 18% GST";
		}
	}
}
