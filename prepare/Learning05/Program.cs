using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>{};
        Square s1 = new Square("Red", 3);
        shapeList.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapeList.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapeList.Add(s3);

        foreach (Shape s in shapeList){
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine("");
        }
    }
}