using System;

class CalculateExpression2
{
    static void Main()
    {
        Console.Write("positive integer N (1 < N < 100):");
        int N = int.Parse(Console.ReadLine());
        Console.Write("positive integer K (1 < K < N < 100):");
        int K = int.Parse(Console.ReadLine());
        double factorialN = 1;
        double factorialK = 1;
        for (int i = 1; i <= N; i++)
        {
            factorialN *= i;
            if (i <= K)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine(factorialN / factorialK);
    }
}
