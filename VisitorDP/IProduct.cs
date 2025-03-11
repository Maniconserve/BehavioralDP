namespace VisitorDP
{
	public interface IProduct
	{
		void Accept(IVisitor visitor);
	}
}
