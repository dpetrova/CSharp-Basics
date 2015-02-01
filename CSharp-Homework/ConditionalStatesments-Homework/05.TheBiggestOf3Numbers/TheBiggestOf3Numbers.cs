using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double biggest;
        if (number1 >= number2)
        {
            biggest = number1;
        }
        else
        {
            biggest = number2;
        }
        if (number3 >= biggest)
        {
            biggest = number3;
        }
        Console.WriteLine("biggest:{0}", biggest);
    }
}
