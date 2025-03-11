namespace VisitorDP
{
	public class PercentageDiscountVisitor : IVisitor
	{
		private readonly double _percentage;

		public PercentageDiscountVisitor(double percentage)
		{
			_percentage = percentage;
		}

		public void Visit(Book book)
		{
			double discountedPrice = book.Price * (1 - _percentage / 100);
			Console.WriteLine($"Book price after {_percentage}% discount: ${discountedPrice}");
		}

		public void Visit(Electronics electronics)
		{
			double discountedPrice = electronics.Price * (1 - _percentage / 100);
			Console.WriteLine($"Electronics price after {_percentage}% discount: ${discountedPrice}");
		}
	}
}
