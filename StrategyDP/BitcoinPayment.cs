namespace StrategyDP
{
	public class BitcoinPayment : IPaymentStrategy
	{
		public void ProcessPayment(double amount)
		{
			Console.WriteLine($"Processing Bitcoin payment of ${amount}");
			// Bitcoin payment logic
		}
	}
}
