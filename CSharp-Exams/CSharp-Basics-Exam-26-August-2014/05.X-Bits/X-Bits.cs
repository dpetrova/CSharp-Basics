using System;
using System.Collections.Generic;

class Program
{
    //You are given 8 integer numbers. Write a program to count all X-bits. X-bits are groups of 9 bits (3 rows x 3 columns)
    //forming the letter "X". Your task is to count all X-bits and print their count on the console. Valid X-bits consist of
    //3 numbers where their corresponding bit indexes are exactly {"101", "010", "101"}. All other combinations like:
    //{"111", "010", "101"} or {"111", "111", "111"} are invalid. All valid X-bits can be part of multiple X-bits (with 
    //overlapping). Check the example on the right to understand your task better.
    //Input
    //The input data should be read from the console. 
    //•	On the first 8 lines, you will be given 8 integers.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 1 line:
    //•	At the first line print the count of the X-bits.
    //Constraints
    //•	The 8 input integers will be in the range [0 … 2 147 483 647].
    //•	Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        int countX = 0;
        for (int i = 0; i < numbers.Count - 2; i++)
        {
            int firstNumber = numbers[i];
            int secondNumber = numbers[i + 1];
            int thirdNumber = numbers[i + 2];
            while (firstNumber > 0 & secondNumber > 0 & thirdNumber > 0)
            {
                if ((firstNumber & 1) == 1 & ((firstNumber >> 1) & 1) == 0 & ((firstNumber >> 2) & 1) == 1 & 
                        (secondNumber & 1) == 0 & ((secondNumber >> 1) & 1) == 1 & ((secondNumber >> 2) & 1) == 0 &
                            (thirdNumber & 1) == 1 & ((thirdNumber >> 1) & 1) == 0 & ((thirdNumber >> 2) & 1) == 1)
                {
                    countX++;
                }
                firstNumber = firstNumber >> 1;
                secondNumber = secondNumber >> 1;
                thirdNumber = thirdNumber >> 1;
            }
        }
        Console.WriteLine(countX);
    }
}
