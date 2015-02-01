using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigit7 = (number / 100) % 10 == 7 || (number / 100) % 10 == -7;
        Console.WriteLine("Third digit 7? {0}", thirdDigit7);
    }
}
