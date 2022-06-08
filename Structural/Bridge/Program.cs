using Bridge;

Console.WriteLine("Line drawn using OpenGL commands:");
Shape line = new Line(new OpenGLApi());
line.Draw();
Console.WriteLine();

Console.WriteLine("Rectangle SVG");
Shape rectangle = new Rectangle(new SvgApi());
rectangle.Draw();
Console.WriteLine();