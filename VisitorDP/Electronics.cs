namespace VisitorDP
{
	public class Electronics : IProduct
	{
		public double Price { get; }

		public Electronics(double price)
		{
			Price = price;
		}

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
