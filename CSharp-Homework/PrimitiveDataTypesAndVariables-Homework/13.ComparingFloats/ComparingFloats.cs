using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Number1 = ");
        double Number1 = double.Parse(Console.ReadLine());
        Console.Write("Number2 = ");
        double Number2 = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool isEqual = Math.Abs(Number1 - Number2) < eps;
        Console.WriteLine(isEqual);
    }
}
