namespace TemplateDP
{
	public class CashOnDeliveryOrder : OrderProcessTemplate
	{
		protected override void ApplyDiscount()
		{
			Console.WriteLine("No discount applied for Cash on Delivery.");
		}

		protected override void ProcessPayment()
		{
			Console.WriteLine("Payment will be collected upon delivery.");
		}

		protected override void ShipOrder()
		{
			Console.WriteLine("Order shipped with additional shipping charges for Cash on Delivery.");
		}
	}
}
