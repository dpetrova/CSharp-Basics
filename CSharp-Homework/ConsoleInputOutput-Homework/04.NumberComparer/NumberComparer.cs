using System;

class NumberComperor
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double greaterNumber = a > b ? a : b;
        Console.WriteLine(greaterNumber);
    }
}

