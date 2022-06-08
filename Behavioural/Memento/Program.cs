using Memento;

var document = new Document();
var history = new DocumentHistory(document);

history.Snapshot();

document.Append("The quick brown racoon jumped over the clothes");
history.Snapshot();

document.Italic();
history.Snapshot();

document.Bold();
WriteDocument("Initial doc:", document);

history.Restore(1);
WriteDocument("Restore #1", document);

history.Restore(2);
WriteDocument("Restore #2", document);


static void WriteDocument(string text, Document document)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(document.ToString());
}