using System;
using System.Collections.Generic;

class HalfByteSwapper
{
    //You are given four 32 bit integer numbers. Your task is to swap groups of 4 bits between the 4 numbers. You will be
    //given series of commands. Commands end when the last command given is "End". Each command consists of 2 lines each
    //holding 2 numbers separated by space. The first number in the command shows which number (0 -3) will be manipulated
    //and the second number which group (0-7) of 4 bits will be swapped. The 2 lines in each command show the 2 numbers that
    //will swap groups of 4 bits. Print the four numbers after all commands have been executed. 
    //See the examples on the right to understand you task better. 
    //Input
    //Input data is read from the console.
    //•	On the first 4 lines you will be given 4 32 bit integer numbers
    //•	On each of the next 2 lines will be a single command showing the 2 numbers and groups that will swap bits.
    //•	On the last line on the input will be given the command "End" indicting no more commands will be given
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console.
    //•	Print the 4 input numbers on separate line after all commands are executed
    //Constraints
    //•	The 4 input numbers will be in the range [0... 4, 294,967,295].
    //•	The first number in the command will be between [0-3] and the second between [0-7] 
    //•	Time limit: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        List<uint> numbers = new List<uint>();
        for (int i = 0; i < 4; i++)
        {
            numbers.Add(uint.Parse(Console.ReadLine()));
        }
        List<byte> firstCommands = new List<byte>();
        List<byte> secondCommands = new List<byte>();
        while (true)
        {
            string[] inputFirstCommands = Console.ReadLine().Split();
            if (inputFirstCommands[0] == "End")
            {
                break;
            }
            firstCommands.Add(byte.Parse(inputFirstCommands[0]));
            firstCommands.Add(byte.Parse(inputFirstCommands[1]));
            string[] inputSecondCommands = Console.ReadLine().Split();
            secondCommands.Add(byte.Parse(inputSecondCommands[0]));
            secondCommands.Add(byte.Parse(inputSecondCommands[1]));
            for (int j = 0; j < 4; j++)
            {
                uint bitsFirstNumber = (numbers[firstCommands[0]] >> (4 * firstCommands[1]) + j) & 1;
                uint bitsSecondNumber = (numbers[secondCommands[0]] >> (4 * secondCommands[1]) + j) & 1;
                bitsFirstNumber = bitsFirstNumber << ((4 * secondCommands[1]) + j);
                bitsSecondNumber = bitsSecondNumber << ((4 * firstCommands[1]) + j);
                uint maskBitsFirstNumber = ~((uint)1 << (4 * firstCommands[1]) + j);
                uint maskBitsSecondNumber = ~((uint)1 << (4 * secondCommands[1]) + j);
                numbers[firstCommands[0]] = numbers[firstCommands[0]] & maskBitsFirstNumber;
                numbers[secondCommands[0]] = numbers[secondCommands[0]] & maskBitsSecondNumber;
                numbers[firstCommands[0]] = numbers[firstCommands[0]] | bitsSecondNumber;
                numbers[secondCommands[0]] = numbers[secondCommands[0]] | bitsFirstNumber;
            }
            firstCommands.Clear();
            secondCommands.Clear();
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
