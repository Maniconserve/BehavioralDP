namespace StrategyDP
{
	public class PayPalPayment : IPaymentStrategy
	{
		public void ProcessPayment(double amount)
		{
			Console.WriteLine($"Processing PayPal payment of ${amount}");
			// PayPal payment logic
		}
	}
}
