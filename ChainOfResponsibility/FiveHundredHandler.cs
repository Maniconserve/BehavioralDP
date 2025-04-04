﻿namespace ChainOfResponsibility
{
	public class FiveHundredHandler : Handler
	{
		public override void DispatchNote(long requestedAmount)
		{
			long numberofNotesToBeDispatched = requestedAmount / 500;
			if (numberofNotesToBeDispatched > 0)
			{
				if (numberofNotesToBeDispatched > 1)
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
				}
				else
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
				}
			}
			long pendingAmountToBeProcessed = requestedAmount % 500;
			if (pendingAmountToBeProcessed > 0)
			{
				NextHandler.DispatchNote(pendingAmountToBeProcessed);
			}
		}
	}
}
