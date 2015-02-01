using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double first = 0;
        double second = 0;
        double third = 0;
        if (number1 >= number2 && number1 >= number3)
        {
            first = number1;
            if (number2 >= number3)
            {
                second = number2;
                third = number3;
            }
            else
            {
                second = number3;
                third = number2;
            }
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            first = number2;
            if (number1 >= number3)
            {
                second = number1;
                third = number3;
            }
            else
            {
                second = number3;
                third = number1;
            }
        }
        else
        {
            first = number3;
            if (number1 >= number2)
            {
                second = number1;
                third = number2;
            }
            else
            {
                second = number2;
                third = number1;
            }
        }
        Console.Write("{0}, {1}, {2}", first, second, third);
    }
}
