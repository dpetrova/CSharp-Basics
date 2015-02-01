using System;
using System.Collections.Generic;
using System.Linq;

class Pairs
{
    //You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, the third and the
    //fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. Your task is to write
    //a program to check whether all pairs have the same value or print the max difference between two consecutive values.
    //Input
    //You are given at the console even number of integers, all in a single line, separated by a space.
    //Output
    //The output is single line, printed at the console.
    //•	In case all pairs have the same value, print "Yes, value=…" and the value.
    //•	Otherwise, print "No, maxdiff=…" and the maximal difference between two consecutive values, always a positive integer.
    //Constraints
    //•	All input values will be integers in the range [-1000…1000] inclusive.
    //•	The count of elements is even number in the range [2…1000] inclusive.
    //•	Allowed work time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        int[] numbers = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            numbers[i] = int.Parse(str[i]);
        }
        List<int> sums = new List<int>();
        for (int i = 0; i < numbers.Length; i += 2) //+=2 because sums are from 2 numbers
        {
            sums.Add(numbers[i] + numbers[i + 1]);
        }
        if (sums.Count == 1) //if we have only 2 numbers that forms 1 sum
        {
            Console.WriteLine("Yes, value={0}", sums[0]);
        }
        else
        {
            List<int> differences = new List<int>();
            for (int i = 0; i < sums.Count - 1; i++)
            {
                differences.Add(Math.Abs(sums[i] - sums[i + 1]));
            }
            int maxDiff = differences.Max();
            if (maxDiff == 0) // this means tah all sums are equal
            {
                Console.WriteLine("Yes, value={0}", sums[0]);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
