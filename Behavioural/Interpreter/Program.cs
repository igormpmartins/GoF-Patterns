using Interpreter;

var evaluator = new Evaluator();

Console.WriteLine("Enter RPN expression:");
string text = Console.ReadLine();

var tree = evaluator.Parse(text);

Console.WriteLine($"The result is... {tree.Interpret()}");
