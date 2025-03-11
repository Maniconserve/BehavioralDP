// Input expression
using InterpreterDP;

string expression = "5 + 3 - 2";

// Parse the expression and build the AST
Parser parser = new Parser();
IExpression ast = parser.Parse(expression);

// Interpret (evaluate) the AST
int result = ast.Interpret();
Console.WriteLine($"Result of '{expression}' is: {result}");