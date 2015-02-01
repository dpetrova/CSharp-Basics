using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("enter an integer number:");
        long num = long.Parse(Console.ReadLine());
        long residue;
        string binary = null;
        if (num == 0)
        {
            binary = "0";
        }
        while (num > 0)
        {
            residue = num % 2;
            num /= 2;
            binary = residue.ToString() + binary;
        }
        Console.WriteLine(binary);
    }
}
