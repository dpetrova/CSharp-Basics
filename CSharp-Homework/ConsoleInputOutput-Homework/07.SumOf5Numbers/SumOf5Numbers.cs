using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("enter 5 numbers, separated by a space:");
        string[] numbers = Console.ReadLine().Split();
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            double number = Convert.ToDouble(numbers[i]);
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

