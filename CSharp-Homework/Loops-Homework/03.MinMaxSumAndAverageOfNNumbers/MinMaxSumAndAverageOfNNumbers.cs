using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] number = new double[n];
        double currentMin = double.MaxValue;
        double currentMax = double.MinValue;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            number[i] = double.Parse(Console.ReadLine());

            if (number[i] <= currentMin)
            {
                currentMin = number[i];
            }
            if (number[i] >= currentMax)
            {
                currentMax = number[i];
            }
            sum = sum + number[i];
        }
        avg = sum / n;
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:f2}", currentMin, currentMax, sum, avg);
    }
}
