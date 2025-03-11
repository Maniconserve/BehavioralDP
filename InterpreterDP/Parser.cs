namespace InterpreterDP
{
	public class Parser
	{
		public IExpression Parse(string expression)
		{
			var tokens = expression.Split(' ');
			var stack = new Stack<IExpression>();

			for (int i = 0; i < tokens.Length; i++)
			{
				if (tokens[i] == "+")
				{
					var left = stack.Pop();
					var right = new NumberExpression(int.Parse(tokens[++i]));
					stack.Push(new AddExpression(left, right));
				}
				else if (tokens[i] == "-")
				{
					var left = stack.Pop();
					var right = new NumberExpression(int.Parse(tokens[++i]));
					stack.Push(new SubtractExpression(left, right));
				}
				else
				{
					stack.Push(new NumberExpression(int.Parse(tokens[i])));
				}
			}

			return stack.Pop();
		}
	}
}
