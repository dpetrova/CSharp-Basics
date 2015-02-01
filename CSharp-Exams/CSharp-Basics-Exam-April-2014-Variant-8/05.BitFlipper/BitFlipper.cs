using System;

class BitFlipper
{
    //We are given a bit sequence in the form of 64-bit integer. We pass through the bits from left to right and we flip all
    //sequences of 3 equal bits (111  000, 000  111). For example, 8773276988229695713 represents the bit sequence
    //0111100111000000111100001111000000011111100010100011100011100001. We flip from left to right all 3 consecutive equal
    //bits: 0111100111000000111100001111000000011111100010100011100011100001 ->  
    //      0000100000111111000111100001111111000000011110111100011100011101. The obtained 64-bit number after flipping is
    //594226797558351645.
    //Your task is to write a program that enters a 64-bit integer, performs the above described flipping, and prints 
    //the obtained result as a 64-bit integer.
    //Input
    //The input data should be read from the console. It consists of a single 64-bit integer number.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //Print at the console the 64-bit integer, representing the obtained bits after the flipping.
    //Constraints
    //•	The input number will be a 64-bit integer in the range [0 … 18 446 744 073 709 551 615].
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString((Int64)number, 2).PadLeft(64, '0'));
        for (int bit = 63; bit >= 2; bit--)
        {
            ulong last3Bits = (number >> bit - 2) & 7;
            //Console.WriteLine(Convert.ToString((Int64)last3Bits, 2).PadLeft(64, '0'));

            if (last3Bits == 0)
            {
                number = number | (ulong)7 << (bit - 2);
                bit -= 2;
            }
            else if (last3Bits == 7)
            {
                number = number & ~((ulong)7 << (bit - 2));
                bit -= 2;
            }
            //Console.WriteLine(Convert.ToString((Int64)number, 2).PadLeft(64, '0'));
        }
        Console.WriteLine(number);
    }
}
