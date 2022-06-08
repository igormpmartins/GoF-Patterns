using Composite;

var html = new Html();
var body = new Body();
var p = new P();
var text = new Text("Yo wold!");
p.AddChild(text);
body.AddChild(p);
html.AddChild(body);

Console.WriteLine(html.Render());