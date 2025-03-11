namespace StrategyDP
{
	public class CreditCardPayment : IPaymentStrategy
	{
		public void ProcessPayment(double amount)
		{
			Console.WriteLine($"Processing credit card payment of ${amount}");
			// Credit card payment logic
		}
	}
}
