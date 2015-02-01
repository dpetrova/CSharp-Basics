using System;

class ExchangeVariablesValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange: a = {0}; b= {1}", a, b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After exchange: a = {0}; b= {1}", a, b);
    }
}
