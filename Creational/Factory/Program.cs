using Factory;

ToyCreator creator;

Console.WriteLine("Creating a firetruck toy...");
creator = new FiretruckCreator();
creator.MakeToy();
Console.WriteLine();

Console.WriteLine("Creating a duck...");
creator = new DuckCreator();
creator.MakeToy();
Console.WriteLine();
