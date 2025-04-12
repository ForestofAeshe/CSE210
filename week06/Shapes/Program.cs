using System;
using Shape;
class Program
{
    static void Main(string[] args)
    {
        List<Shape.Shape> shapes = new List<Shape.Shape>();

        Square shape1 = new Square("Blue", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Red", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 4);
        shapes.Add(shape3);

        foreach (Shape.Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shap has an area of {area}");
        }
    }
}