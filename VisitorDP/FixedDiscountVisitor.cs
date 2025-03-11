namespace VisitorDP
{
	public class FixedDiscountVisitor : IVisitor
	{
		private readonly double _discount;

		public FixedDiscountVisitor(double discount)
		{
			_discount = discount;
		}

		public void Visit(Book book)
		{
			double discountedPrice = book.Price - _discount;
			Console.WriteLine($"Book price after fixed discount: ${discountedPrice}");
		}

		public void Visit(Electronics electronics)
		{
			double discountedPrice = electronics.Price - _discount;
			Console.WriteLine($"Electronics price after fixed discount: ${discountedPrice}");
		}
	}
}
