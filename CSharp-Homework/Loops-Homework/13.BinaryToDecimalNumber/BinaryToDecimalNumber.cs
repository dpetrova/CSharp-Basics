using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("enter a binary integer as string:");
        string number = Console.ReadLine();
        long num = 0;
        for (int i = 0; i < number.Length; i++)
        {
            //if (number[i] == '1')
            //{
                num = num + int.Parse("" + number[i]) * (long)Math.Pow(2, number.Length - 1 - i);
            //}
            //else
            //{
            //    continue;
            //}
        }
        Console.WriteLine(num);
    }
}
