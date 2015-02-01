using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("height:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("perimeter: {0} \narea: {1}", perimeter, area);
    }
}
