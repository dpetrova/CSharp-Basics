using System;

class CalculateExpression
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factorial = 1;
        double power = x;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            power = Math.Pow(x, i);
            factorial = factorial * i;
            sum = sum + (factorial / power);
        }
        Console.WriteLine("{0:f5}", sum);
    }
}
