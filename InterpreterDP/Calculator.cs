namespace InterpreterDP
{
	public class Calculator
	{
		public int Evaluate(string expression)
		{
			var tokens = expression.Split(' ');
			int result = int.Parse(tokens[0]);

			for (int i = 1; i < tokens.Length; i += 2)
			{
				string op = tokens[i];
				int number = int.Parse(tokens[i + 1]);

				if (op == "+")
				{
					result += number;
				}
				else if (op == "-")
				{
					result -= number;
				}
				else
				{
					throw new ArgumentException($"Invalid operator: {op}");
				}
			}

			return result;
		}
	}
	
	//Problems with This Approach:
	//Tight Coupling:

	//The parsing and evaluation logic is tightly coupled in the Evaluate method.

	//Violation of Open/Closed Principle:

	//Adding a new operator (e.g., * or /) requires modifying the Evaluate method.

	//Hard to Test:

	//The Evaluate method is difficult to test because it handles both parsing and evaluation.

	//Limited Flexibility:

	//The system cannot easily handle more complex expressions or grammar rules.
}

