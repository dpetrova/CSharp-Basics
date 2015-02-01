using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("base a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("base b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("height:");
        double h = double.Parse(Console.ReadLine());
        double area = (h * (a + b)) / 2;
        Console.WriteLine("Trapezoid's area is {0}", area);
    }
}
