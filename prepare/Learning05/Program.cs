using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);

        Rectangle rectangle = new Rectangle("blue", 4, 5);

        Circle circle = new Circle("green", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
        }
    }
}