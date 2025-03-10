namespace TemplateDP
{
	public abstract class OrderProcessTemplate
	{
		public void ProcessOrder()
		{
			SelectItems();
			ApplyDiscount();
			ProcessPayment();
			SendReceipt();
			ShipOrder();
		}

		protected void SelectItems()
		{
			Console.WriteLine("Items selected.");
		}

		protected abstract void ApplyDiscount();
		protected abstract void ProcessPayment();

		protected void SendReceipt()
		{
			Console.WriteLine("Receipt sent to the customer.");
		}

		protected virtual void ShipOrder()
		{
			Console.WriteLine("Order shipped with standard shipping.");
		}
	}

}
