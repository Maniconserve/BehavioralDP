﻿namespace ChainOfResponsibility
{
	public class HundredHandler : Handler
	{
		public override void DispatchNote(long requestedAmount)
		{
			long numberofNotesToBeDispatched = requestedAmount / 100;
			if (numberofNotesToBeDispatched > 0)
			{
				if (numberofNotesToBeDispatched > 1)
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
				}
				else
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
				}
			}
		}
	}
}
