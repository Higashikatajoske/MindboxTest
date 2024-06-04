﻿// See https://aka.ms/new-console-template for more information
using FiguresLibrary;

Circle square = new Circle(2);
Triangle triangle = new Triangle(6, 7, 10);
Triangle triangle2 = new Triangle(3, 3, 3);
Triangle rightAngleTriangle = new Triangle(3, 4, 5);
Triangle rightAngleTriangle2 = new Triangle(5, 4, 3);

Console.WriteLine(square.GetSquare());
Console.WriteLine(triangle.GetSquare());
Console.WriteLine(triangle2.GetSquare());
Console.WriteLine(triangle2.IsRightAngle);
Console.WriteLine(rightAngleTriangle.GetSquare());
Console.WriteLine(rightAngleTriangle.IsRightAngle);
Console.WriteLine(rightAngleTriangle2.GetSquare());
Console.WriteLine(rightAngleTriangle2.IsRightAngle);

Console.ReadKey();