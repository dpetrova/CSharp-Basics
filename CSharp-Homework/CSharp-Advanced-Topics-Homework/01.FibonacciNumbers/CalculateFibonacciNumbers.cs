using System;
using System.Numerics;

class CalculateFibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }

    static void Fib(int n)
    {
        BigInteger previousMember = 0;
        BigInteger nextMember = 1;
        BigInteger sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = previousMember + nextMember;
            previousMember = nextMember;
            nextMember = sum;
        }
        Console.WriteLine("Fib({0})= {1} ", n, nextMember);
    }
}

