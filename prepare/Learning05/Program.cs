using System;
using System.Drawing;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {   
        List<Shape> shapes = new List<Shape>();

        // Test for Square class, inherited and morphed from the Shape class
        Square square1 = new Square(5, "blue");
        string color1 = square1.GetColor();
        double area1 = square1.GetArea();
        Console.WriteLine("Square 1 Color: " + color1);
        Console.WriteLine("Square 1 Area: " + area1);

        // Test for Rectangle class, inherited and morphed from the Shape class
        Rectangle rectangle2 = new Rectangle(5, 4, "pink");
        string color2 = rectangle2.GetColor();
        double area2 = rectangle2.GetArea();
        Console.WriteLine("Rectangle 2 Color: " + color2);
        Console.WriteLine("Rectangle 2 Area: " + area2);

        // Test for Circle class, inherited and morphed from the Shape class
        Circle circle3 = new Circle(5, "yellow");
        string color3 = circle3.GetColor();
        double area3 = circle3.GetArea();
        Console.WriteLine($"Circle 3 Color: {color3}");
        Console.WriteLine($"Circle 3 Area: {area3}");

        shapes.Add(new Square(10, "Black"));
        shapes.Add(new Rectangle(7, 8, "White"));
        shapes.Add(new Circle(5, "Grey"));

        foreach (Shape shape in shapes) // remember to state the datatype of the iterate variable
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");


        }
    }
}
