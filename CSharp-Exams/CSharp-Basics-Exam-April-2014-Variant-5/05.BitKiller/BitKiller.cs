﻿using System;

class BitKiller
{
    //You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.  You are given also a number step. 
    //Write a program to remove (kill) all the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
    //In case the last byte have less than 8 bits, add trailing zeroes at its right end. Bits in each byte are counted
    //from the leftmost to the rightmost. Bits are numbered starting from 0.
    //Input
    //•	The input data should be read from the console.
    //•	The number n stays at the first line.
    //•	The number step stays at the second line.
    //•	At each of the next n lines n bytes are given, each at a separate line. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Print the output bytes, each at a separate line.
    //Constraints
    //•	The number n will be an integer number in the range [1…100].
    //•	The number step will be an integer number in the range [1…20].
    //•	The n numbers will be integers in the range [0…255].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int outputBits = 0;
        int outputBitsCount = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if (!((index % step == 1) || (step == 1 && index > 0)))
                {
                    int bitValue = (number >> bit) & 1;
                    outputBits = outputBits << 1;
                    outputBits = outputBits | bitValue;
                    outputBitsCount++;
                    if (outputBitsCount == 8)
                    {
                        //We have 8 bits (1 byte) --> flush it to the output
                        Console.WriteLine(outputBits);
                        outputBits = 0;
                        outputBitsCount = 0;
                    }
                }
                index++;
            }
        }
        if (outputBitsCount > 0)
        {
            // We have a few bits left --> add trailing zeroes and flush them to the output
            outputBits = outputBits << (8 - outputBitsCount);
            Console.WriteLine(outputBits);
        }
    }
}
