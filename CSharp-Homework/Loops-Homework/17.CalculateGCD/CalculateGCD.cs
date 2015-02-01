using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int temp;
        int remainder = int.MaxValue;
        if (a == 0)
        {
             Console.WriteLine("Greatest common divisor is: {0}", b);
             return;
        }
        else if (b == 0)
        {
             Console.WriteLine("Greatest common divisor is: {0}", a);
             return;
        }
        if (a < b) //change their positions, so the first number is greater
        {
            temp = a;
            a = b;
            b = temp;
        }
        while (remainder > 0)
        {
            remainder = a % b;
            if (remainder == 0)
            {
                Console.WriteLine("Greatest common divisor is: {0}", b);
            }
            else
            {
                a = b;
                b = remainder;
                continue;
            }
        }
    }
}
