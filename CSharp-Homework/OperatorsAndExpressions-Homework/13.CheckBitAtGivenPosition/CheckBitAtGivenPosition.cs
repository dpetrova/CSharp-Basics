using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("binary represantation : {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("bit's index:");
        int index = int.Parse(Console.ReadLine());
        bool bit = ((number >> index) & 1) == 1;
        Console.WriteLine("bit at index {0} = 1 {1}", index, bit);
    }
}
