namespace ChainOfResponsibility
{
	public class ATM
	{
		private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
		private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
		private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
		private HundredHandler hundredHandler = new HundredHandler();
		public ATM()
		{
			twoThousandHandler.SetNextHandler(fiveHundredHandler);
			fiveHundredHandler.SetNextHandler(twoHundredHandler);
			twoHundredHandler.SetNextHandler(hundredHandler);
		}
		public void Withdraw(long requestedAmount)
		{
			if (requestedAmount % 100 == 0)
			{
				twoThousandHandler.DispatchNote(requestedAmount);
			}
			else
			{
				Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
			}
		}
	}
}
