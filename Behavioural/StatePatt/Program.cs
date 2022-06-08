using StatePatt;

var machine = new VendingMachine();

Console.WriteLine("Kevin's Dream Machine");
Console.WriteLine("1: Insert coin");
Console.WriteLine("2: Eject coin");
Console.WriteLine("3: Push button (M&M)");
Console.WriteLine("4: Quit");

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter command: ");
    string command = Console.ReadLine();

    if (String.IsNullOrEmpty(command) || command.Equals("4"))
        break;

    switch (command)
    {
        case "1":
            machine.InsertCoin();
            break;
        case "2":
            machine.EjectCoin();
            break;
        case "3":
            machine.PushButton();
            break;
        default:
            break;
    }

}

