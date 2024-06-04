// See https://aka.ms/new-console-template for more information
using FiguresLibrary;

Circle square = new Circle(2);
Triangle triangle = new Triangle(3, 3, 3);

Console.WriteLine(square.GetSquare());
Console.WriteLine(triangle.GetSquare());
Console.ReadKey();