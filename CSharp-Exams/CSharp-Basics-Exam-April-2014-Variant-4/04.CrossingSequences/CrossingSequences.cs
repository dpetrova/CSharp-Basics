using System;
using System.Collections.Generic;

class CrossingSequences
{
    //We’re dealing with two sequences: the Tribonacci sequence, where every number is the sum of the previous three, 
    //and the number spiral, defined by walking over a grid of numbers as a spiral (right, down, left, up, right, down, up, left, …)
    //and writing down the current number every time we take a turn. Find the first number that appears in both sequences.
    //Example
    //Let the Tribonacci sequence start with 1, 2 and 3. It will therefore contain the numbers 1, 2, 3, 6, 11, 20, 37, 68, 125, 230,
    //423, 778, 1431, 2632, 4841, 8904, 16377, 30122, 55403, 101902, and so on.
    //Also, let the number spiral start with 5 and have a step of 2; it then contains he numbers 5, 7, 9, 13, 17, 23, 29, 37, etc.
    //Since 37 is the first number that is both in the Tribonacci sequence and in the spiral, it is the answer.
    //Input
    //The input data should be read from the console.
    //• On the first three lines of input, you will read three integers, representing the three initial numbers of the 
    //Tribonacci sequence.
    //•	On the next two lines of input, you will read two integers, representing the initial number and the step of each grid cell 
    //for the number spiral.
    //The input data will always be valid and in the format described. There is no need to check it.
    //Output
    //The output must be printed on the console.
    //On the single line of output you must print the smallest number that appears in both sequences. If no number in the range [1 … 1 000 000] exists that appears in both sequences, print "No".
    //Constraints
    //•	All numbers in the input will be in the range [1 … 1 000 000].
    //•	Allowed work time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int firstTribonacci = int.Parse(Console.ReadLine());
        int secondTribonacci = int.Parse(Console.ReadLine());
        int thirdTribonacci = int.Parse(Console.ReadLine());
        int nextTribonacci = 0;
        int spiralNum = int.Parse(Console.ReadLine());
        int initialSpiralStep = int.Parse(Console.ReadLine());
        int nextSpiralStep = initialSpiralStep;
        int max = 1000000;
        int count = 0;
        List<int> spiralNumbers = new List<int>();
        spiralNumbers.Add(spiralNum);
        List<int> tribonacciNumbers = new List<int>();
        tribonacciNumbers.Add(firstTribonacci);
        tribonacciNumbers.Add(secondTribonacci);
        tribonacciNumbers.Add(thirdTribonacci);
        
        //calculate Tribonacci numbers in range [1 … 1 000 000] 
        while (nextTribonacci <= max)
        {
            nextTribonacci = firstTribonacci + secondTribonacci + thirdTribonacci;
            tribonacciNumbers.Add(nextTribonacci);
            firstTribonacci = secondTribonacci;
            secondTribonacci = thirdTribonacci;
            thirdTribonacci = nextTribonacci;
        }
        //calculate spiral numbers in range [1 … 1 000 000] 
        for (int i = 1; i < int.MaxValue; i++)
        {
            if (i != 1 && i % 2 != 0)
            {
                nextSpiralStep = nextSpiralStep + initialSpiralStep;
            }
            spiralNum += nextSpiralStep;
            spiralNumbers.Add(spiralNum);
            if (spiralNum >= max)
            {
                break;
            }
        }

        //comparing the two sequences for crossing equal element
        for (int i = 0; i < tribonacciNumbers.Count; i++)
        {
            for (int j = 0; j < spiralNumbers.Count; j++)
            {
                if (tribonacciNumbers[i] == spiralNumbers[j] && tribonacciNumbers[i] <= max)
                {
                    Console.WriteLine(tribonacciNumbers[i]);
                    count++;
                    break;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
