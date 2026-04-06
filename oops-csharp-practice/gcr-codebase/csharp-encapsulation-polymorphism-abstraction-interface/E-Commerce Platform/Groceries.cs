namespace BridgeLabz.E_Commerce_Platform
{
	public class Groceries : Product
	{
		public Groceries(int id, string name, double price)
			: base(id, name, price) { }

		public override double CalculateDiscount()
		{
			return Price * 0.05; // 5% discount
		}
	}
}
