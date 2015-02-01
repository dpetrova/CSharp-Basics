using System;
using System.Collections.Generic;

class DoubleDowns
{
    //You are given a number N and N integers. Write a program to count all couples of bits between every two integers
    //(num[0] and num[1], num[1] and num[2], …, num[N-2] and num[N-1]). You should count 3 kinds of couples: vertical, 
    //left-diagonal and right-diagonal like at the example on the right. Every “1” bit can be part of multiple couples. 
    //Input
    //The input data should be read from the console. 
    //•	The number n stays at the first line.
    //•	At each of the next n lines n integers are given, each at a separate line. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 3 lines:
    //•	At the first line print the count of the right diagonal couples.
    //•	At the second line print the count of the left diagonal couples.
    //•	At the third line print the count of the vertical couples.
    //Constraints
    //•	The number n will be an integer number in the range [2…100].
    //•	The n numbers will be integers in the range [0…2 147 483 647].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        int countVert = 0;
        int countLeftDiag = 0;
        int countRightDiag = 0;
        for (int i = 0; i < N - 1; i++)
        {
            int prevNumber = numbers[i];
            int nextNumber = numbers[i + 1];
            while (prevNumber > 0 & nextNumber > 0)
            {
                //Console.WriteLine(Convert.ToString(prevNumber, 2));
                //Console.WriteLine(Convert.ToString(nextNumber, 2));
                countVert += (prevNumber & 1) & (nextNumber & 1);
                countLeftDiag += (prevNumber & 1) & ((nextNumber >> 1) & 1);
                countRightDiag += ((prevNumber >> 1) & 1) & (nextNumber & 1);
                prevNumber = prevNumber >> 1;
                nextNumber = nextNumber >> 1;
            }
        }
        Console.WriteLine(countRightDiag);
        Console.WriteLine(countLeftDiag);
        Console.WriteLine(countVert);
    }
}
