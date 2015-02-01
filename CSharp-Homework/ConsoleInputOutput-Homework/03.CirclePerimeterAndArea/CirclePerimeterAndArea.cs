using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * radius;
        double area = pi * radius * radius;
        Console.WriteLine("perimeter: {0:0.00} \narea: {1:F2}", perimeter, area);
    }
}

