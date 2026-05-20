using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        Square S1 = new Square("Brown", 5);
        Circle C1 = new Circle("Green", 5);
        Rectangle R1 = new Rectangle("Purple", 5, 4);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(R1);
        shapes.Add(C1);
        shapes.Add(S1);

        foreach (Shape shape in shapes)
        {
            double area4 = shape.GetArea();
            string color4 = shape.GetColor();
            Console.WriteLine(area4);
            Console.WriteLine(color4);
        }




    }
}