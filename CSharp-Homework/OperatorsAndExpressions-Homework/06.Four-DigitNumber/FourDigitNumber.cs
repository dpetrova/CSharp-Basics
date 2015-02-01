using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit integer number, cannot start with 0:");
        int number = int.Parse(Console.ReadLine());
        if ((number < 1000) || (number > 9999))
        {
            Console.WriteLine("out of range");
        }
        else
        {
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("sum of digits: {0}", sum);
            Console.WriteLine("reversed: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("last digit in front: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
