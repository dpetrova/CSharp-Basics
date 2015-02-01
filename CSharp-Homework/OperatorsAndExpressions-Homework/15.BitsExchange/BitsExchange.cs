using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("unsigned integer number:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(32, '0')); // convert the number to 32bit binary
        for (int i = 0; i < 3; i++)
        {
            uint shiftRight345 = number >> (3 + i); // shift bits 3,( 4, 5) to right
            uint bits345 = shiftRight345 & 1; // get bits 3,( 4, 5): 1 or 0
            uint shiftRight242526 = number >> (24 + i); // shift bits 24, (25, 26) to right
            uint bits242526 = shiftRight242526 & 1; // get bits 24, (25, 26): 1 or 0
            uint shiftLeft345 = bits345 << (24 + i); // shift bit 3 (,4,5) to positon 24 (,25,26)
            uint shiftLeft242526 = bits242526 << (3 + i); // shift bit 24 (,25,26) to position 3 (,4,5)
            uint mask345 = (uint)~(1 << (3 + i));
            number = number & mask345; // set bit 3 (,4,5) to zero in the initial number
            uint mask242526 = (uint)~(1 << (24 + i));
            number = number & mask242526; // set bit 24 (,25,26) to zero in the initial number
            number = number | shiftLeft242526; // set zeroes at positions 3 (,4,5) with exchanged bits
            number = number | shiftLeft345; // set zeroes at positions 24 (,25,26) with exchanged bits
        }
        Console.WriteLine("result = {0}", number);
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
