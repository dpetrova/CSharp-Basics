using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("positive integer N (1 < N < 100):");
        int N = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factDivident = 1;
        decimal factDivisor = 1;
        for (int i = 1; i <= 2 * N; i++)
        {
            factDivident *= i;
            if (i <= N + 1)
            {
                factDivisor *= i;
            }
            if (i <= N)
            {
                factorialN *= i;
            }
        }
        decimal result = factDivident / (factDivisor * factorialN);
        Console.WriteLine(result);
    }
}
