using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    //We are given n numbers, e.g. {3, 7, 2, 8, 1, 4, 6, 9}. We split them into triples: sequences of 3 consecutive numbers
    //(except the last sequence that could have 1 or 2 numbers). In our example, the numbers are split into these triples:
    //the first three numbers {3, 7, 2}; the second three numbers {8, 1, 4}; the last two numbers {6, 9}. 
    //Write a program that enters n numbers and finds the triple with biggest sum of numbers. In our example this is
    //the last triple: {6, 9}. In case there are several triples with the same biggest sum, print the leftmost of them.
    //Input
    //The input data should be read from the console. The input data consists of exactly one line holding the input numbers, separated one from another by a space.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //You have to print at the console the leftmost biggest triple as sequence of up to 3 numbers, separated by a space.
    //Constraints
    //•	The input numbers will be integers in range [-1000 … 1000]. 
    //•	The number of the input numbers n will be between 1 and 1000.
    //•	Allowed work time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string[] nums = Console.ReadLine().Split();
        List<int> numbers = new List<int>();
        List<int> biggestTripple = new List<int>();
        int sum = int.MinValue;
        int biggestSum = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            while (numbers.Count < 3 && i < nums.Length)
            {
                numbers.Add(int.Parse(nums[i]));
                i++;
            }
            i--;
            sum = numbers.Sum();
            if (sum > biggestSum)
            {
                biggestSum = sum;
                biggestTripple.Clear();
                biggestTripple.AddRange(numbers);
                numbers.Clear();
            } 
            else
            {
                numbers.Clear();
                continue;
            }
        }
        for (int i = 0; i < biggestTripple.Count; i++)
        {
            Console.Write("{0} ", biggestTripple[i]);
        }

    }
}
