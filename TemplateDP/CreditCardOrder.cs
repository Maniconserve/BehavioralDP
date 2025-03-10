namespace TemplateDP
{
	public class CreditCardOrder : OrderProcessTemplate
	{
		protected override void ApplyDiscount()
		{
			Console.WriteLine("Applying 10% discount for Credit Card payment.");
		}

		protected override void ProcessPayment()
		{
			Console.WriteLine("Payment processed using Credit Card.");
		}
	}
}
