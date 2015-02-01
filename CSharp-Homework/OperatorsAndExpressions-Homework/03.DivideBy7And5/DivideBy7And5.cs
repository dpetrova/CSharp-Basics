using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        bool divisibleBy5and7 = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("Divided by 7 and 5? {0}", divisibleBy5and7);
    }
}
