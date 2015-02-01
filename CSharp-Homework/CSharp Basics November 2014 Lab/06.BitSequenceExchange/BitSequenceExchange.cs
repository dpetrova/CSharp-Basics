using System;

class BitSequenceExchange
{
    //Modify your program from Bit Exchange to exchange bits 3, 4 and 5 with bits 24, 25 and 26.

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            ulong bit345 = (number >> 3 + i) & 1;
            bit345 = bit345 << (24 + i);
            ulong mask345 = ~((ulong)1 << (3 + i));
            ulong bit242526 = (number >> 24 + i) & 1;
            bit242526 = bit242526 << (3 + i);
            ulong mask242526 = ~((ulong)1 << (24 + i));
            number = number & mask345;
            number = number & mask242526;
            number = number | bit345;
            number = number | bit242526;
        }
        Console.WriteLine(number);
    }
}
