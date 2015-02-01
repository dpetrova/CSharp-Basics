using System;
using System.Collections.Generic;

class ChangeEvenBits
{
    //You are given a number N and you have to read from the console exactly N + 1 integers and additionally an integer L – 
    //the number to be processed. Your task is to count the bits in each of the N input integers (let this be the number len),
    //then change bit to "1" len even positions (0, 2, 4, …) of the input number L. Print on the console the obtained number 
    //and the total number of bits that have actually been changed. To be counted as changed they should have been “0” at first
    //and then changed to “1”. The comments in the example below will help you understand better what you should do. 
    //Note that "0" consists of 1 bit (len=1).
    //Input
    //The input data should be read from the console.
    //•	The first line holds an integer number N – the count of numbers to be read.
    //•	The next N lines hold the N input integers.
    //•	The last line holds an integer number L – the number to be processed.
    //The input data will always be valid and in the format described. There is no need to check it.
    //Output
    //The output should be printed on the console. It should consist of exactly 2 lines:
    //•	On the first line print the number L after setting its even bits.
    //•	On the second line print the number of bits that have actually changed.
    //Constraints
    //•	N will be an integer between 0 and 10.
    //•	The N input integers in the input will be between 0 and 65535.
    //•	L will be an integer number between 0 and 18 446 744 073 709 551 615.
    //•	Allowed working time: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        List<string> numbers = new List<string>();
        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(Convert.ToString(number, 2));
        }
        ulong L = ulong.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int bit = 0; bit < (numbers[i].Length * 2) - 1; bit += 2)
            {
                ulong LChanged = L | ((ulong)1 << bit);
                if (LChanged != L) //if they are not equal it means that have changed a bit
                {
                    counter++;
                }
                L = LChanged;
            }
        }
        Console.WriteLine(L);
        Console.WriteLine(counter);
    }
}
