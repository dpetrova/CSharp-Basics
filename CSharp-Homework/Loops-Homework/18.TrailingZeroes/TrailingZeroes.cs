using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        int counter = 0;
        for (int i = 1; i <= N; i++)
        {
            factorialN *= i;
        }
        while (factorialN % 10 == 0)
        {
            factorialN /= 10;
            counter++;
        }
        Console.WriteLine(counter);
    }
}
