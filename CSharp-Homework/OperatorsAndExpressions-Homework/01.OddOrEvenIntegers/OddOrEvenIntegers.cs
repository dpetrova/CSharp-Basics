using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = number % 2 != 0;
        Console.WriteLine("Odd? {0}", isOdd);
    }
}
