using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double number4 = double.Parse(Console.ReadLine());
        double number5 = double.Parse(Console.ReadLine());
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
        if (number4 >= biggest)
        {
            biggest = number4;
        }
        if (number5 >= biggest)
        {
            biggest = number5;
        }
        Console.WriteLine("biggest:{0}", biggest);
    }
}
