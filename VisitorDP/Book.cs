namespace VisitorDP
{
	public class Book : IProduct
	{
		public double Price { get; }

		public Book(double price)
		{
			Price = price;
		}

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
