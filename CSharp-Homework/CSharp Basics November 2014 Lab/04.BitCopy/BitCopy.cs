using System;

class BitCopy
{
    //Write a program that reads reads a number n (an integer number) and p (a bit position). The program should take the
    //bit at position p from number n and copy it to position 2.
    //Example: We are given the number 4 and position 0. In binary format, 4 is 00000100. We take the bit from position
    //0 – 00000100, and copy it to position 2 - 00000000. Finally, we print the resulting number.
    //Input
    //The input data is read from the console. 
    //•	The input consists of 2 lines:
    //o	On the first line you will receive the number n
    //o	On the second line you will receive the position p 
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console and should consist of only one line – the resulting number.
    //Constraints
    //•	The number n will be an integer number in the range [-2147483648..2147483647].
    //•	The position p will be an integer number in the range [0..31]. 
    //•	Time limit: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
     
        ulong bit = (number >> position) & 1;
        bit = bit << 2;
        ulong mask2 = ~((ulong)1 << 2);
        number = number & mask2;
        number = number | bit;
        Console.WriteLine(number);
    }
}
