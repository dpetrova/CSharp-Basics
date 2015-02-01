using System;

class BitsUp
{
    //You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also a number step.
    //Write a program to set to 1 the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
    //Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
    //Input
    //•	The input data should be read from the console.
    //•	The number n stays at the first line.
    //•	The number step stays at the second line.
    //•	At each of the next n lines n bytes are given, each at a separate line. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Print exactly n bytes, each at a separate line and in range [0..255], obtained by applying the bit inversions over the input sequence.
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
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
            for (int bits = 7; bits >= 0; bits--)
            {
                if ((step == 1 && index > 0 )|| index % step == 1) // it is true when step = index+1; на позиция 0 няма да се сменя, защото стъпката започва от 1
                {
                    number = number | (1 << bits);
                }
                index++;
            }
            Console.WriteLine(number);
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        }
    }
}
