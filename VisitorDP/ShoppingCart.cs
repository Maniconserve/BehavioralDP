namespace VisitorDP
{
	public class ShoppingCart
	{
		private readonly List<IProduct> _products = new List<IProduct>();

		public void AddProduct(IProduct product)
		{
			_products.Add(product);
		}

		public void ApplyDiscount(IVisitor discountVisitor)
		{
			foreach (var product in _products)
			{
				product.Accept(discountVisitor);
			}
		}
	}
}
