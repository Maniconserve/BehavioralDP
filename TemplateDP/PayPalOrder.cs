namespace TemplateDP
{
	public class PayPalOrder : OrderProcessTemplate
	{
		protected override void ApplyDiscount()
		{
			Console.WriteLine("Applying 5% discount for PayPal payment.");
		}

		protected override void ProcessPayment()
		{
			Console.WriteLine("Payment processed using PayPal.");
		}
	}
}
