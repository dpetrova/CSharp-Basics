using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        int bit = (number >> 3) & 1;
        Console.WriteLine("bit #3: {0}", bit);
    }
}
