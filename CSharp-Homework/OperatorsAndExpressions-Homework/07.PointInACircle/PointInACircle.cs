using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x coordinate of a point:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y coordinate of a point:");
        double y = double.Parse(Console.ReadLine());
        double x0 = 0;
        double y0 = 0;
        double radius = 2;
        bool inside = ((x - x0) * (x - x0) + (y - y0) * (y - y0)) <= radius * radius;
        Console.WriteLine("Inside? {0}", inside);
    }
}
