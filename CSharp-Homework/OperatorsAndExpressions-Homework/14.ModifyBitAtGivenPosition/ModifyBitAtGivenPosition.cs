using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("bit's index:");
        int index = int.Parse(Console.ReadLine());
        Console.Write("bit's value (0 or 1):");
        int bitValue = int.Parse(Console.ReadLine());
        int bit = (number >> index) & 1;
        int mask = 1 << index;
        if (bitValue != bit)
        {
            if (bit == 0)
            {
                number = number | mask;
            }
            else
            {
                number = number ^ mask;
            }
        }
        Console.WriteLine("result = {0}", number);
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}
