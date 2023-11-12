// See https://aka.ms/new-console-template for more information
using DrwaingApp.Canvas;
using DrwaingApp.Widgets;

Console.WriteLine("Hello, Drwaing App!");

Canvas canvas = new Canvas();

Square square = new Square() { Name = "Square", X = 10, Y = 10, Side= 100 };
canvas.AddWidget(square);

Rectangle rectangle = new Rectangle() { Name = "Rectangle", X = 20, Y = 20, Height = 100, Width = 150 };
canvas.AddWidget(rectangle);

Circle circle = new Circle() { Name = "Circle", X = 30, Y = 30, Radius = 20 };
canvas.AddWidget(circle);

Ellipse ellipse = new Ellipse() { Name = "Ellipse", X = 40, Y = 40, HorizontalDiameter = 30, VerticalDiameter = 20 };
canvas.AddWidget(ellipse);

TextBox textBox = new TextBox() { Name = "TextBox", X = 50, Y = 50, Height = 50, Width = 100, BackgroundColor = ConsoleColor.Green, Text = "Hello World!" };
canvas.AddWidget(textBox);

canvas.DrawCanvas();
Console.ReadLine();