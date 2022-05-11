// See https://aka.ms/new-console-template for more information
using MethodOverloading;

Console.WriteLine("Hello, World!");
Geometry geometry = new Geometry();
geometry.getArea(5,"square");
geometry.getArea(5,3, "triangle");

Console.WriteLine($"karenin alanı: {geometry.optionalGetArea(4)}");
Console.WriteLine($"darenin alanı: {geometry.optionalGetArea(4, geometry: "circle")}");
Console.WriteLine($"üçgenin alanı: {geometry.optionalGetArea(4,3, geometry: "triangle")}");


