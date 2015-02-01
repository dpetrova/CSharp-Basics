using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("integer n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min:");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max (min <= max):");
        int max = int.Parse(Console.ReadLine());
        Random rand = new Random();
        for (int i = 1; i <= n; i++)
        {
            int RandomNumbers = rand.Next(min, max + 1);
            Console.Write("{0} ", RandomNumbers);
        }
    }
}
