using System;

class BitsInverter
{
    //You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also a number step.
    //Write a program to invert the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
    //Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1.
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
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1)) //(index % step == 1) when index = 1 and when index = step+1 ; index = 2*step+1, etc.
                {
                    num = num ^ (1 << bit); //0 XOR 1 => 1 ; 1 XOR 1 => 0  
                }
            }
            Console.WriteLine(num);
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
        }
    }
}
