using System;
using System.Drawing;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("blue", 6, 3));
        shapes.Add(new Square("green", 5));
        shapes.Add(new Circle("yellow", 7));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color:{shape.Color} ~ Area: {shape.GetArea()}");
        }
    }
}