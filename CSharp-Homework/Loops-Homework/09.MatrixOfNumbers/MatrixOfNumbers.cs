using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("positive integer n (1 <= n <= 20):");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 3}", (i + j));
            }
            Console.WriteLine();
        }
    }
}
