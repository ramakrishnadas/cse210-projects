using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square mySquare = new Square("Red", 3);
        Rectangle myRectangle = new Rectangle("Blue", 4, 5);
        Circle myCircle = new Circle("Green", 6);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(mySquare);
        shapes.Add(myRectangle);
        shapes.Add(myCircle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }

    }
}