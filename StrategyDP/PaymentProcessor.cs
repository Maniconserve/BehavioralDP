namespace StrategyDP
{
	public class PaymentProcessor
	{
		private IPaymentStrategy _paymentStrategy;

		public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
		{
			_paymentStrategy = paymentStrategy;
		}

		public void ProcessPayment(double amount)
		{
			if (_paymentStrategy == null)
			{
				throw new InvalidOperationException("Payment strategy not set");
			}
			_paymentStrategy.ProcessPayment(amount);
		}
	}
}
