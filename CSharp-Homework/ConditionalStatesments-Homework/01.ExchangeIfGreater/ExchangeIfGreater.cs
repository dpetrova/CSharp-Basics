using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
