using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));
        shapes.Add(new Square("Yellow", 2.5));
        shapes.Add(new Rectangle("Purple", 3.5, 8));

        // Iterate through the list and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():F2}");
        }
    }
}