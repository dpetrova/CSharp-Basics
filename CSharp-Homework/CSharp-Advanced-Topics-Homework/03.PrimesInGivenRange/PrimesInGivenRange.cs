using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    private static List<int> primesInRange = new List<int>();

    static void Main()
    {
        Console.Write("enter start of the range:");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("enter end of the range:");
        int endNum = int.Parse(Console.ReadLine());

        FindPrimesInRange(startNum, endNum);

        PrintPrimesInRange(primesInRange);
    }

    static void FindPrimesInRange(int startNum, int endNum)
    {
        if (startNum < 2)
        {
            startNum = 2;
        }

        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(i);
            while (divider <= maxDivider)
            {
                if (i % divider == 0)
                {
                    isPrime = false;
                    break;
                }
                divider++;
            }
            if (isPrime == true)
            {
                primesInRange.Add(i);
            }
        }
    }

    static void PrintPrimesInRange(List<int> primesInRange)
    {
        foreach (var prime in primesInRange)
        {
            Console.Write("{0}, ", prime);
        }
    }
}
