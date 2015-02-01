using System;

class MultiplicationSign
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        int sign1 = Math.Sign(number1);
        int sign2 = Math.Sign(number2);
        int sign3 = Math.Sign(number3);
        if (sign1 == 1 && sign2 == 1 && sign3 == 1)
        {
            Console.WriteLine("+");
        }
        if (sign1 == -1 && sign2 == -1 && sign3 == -1)
        {
            Console.WriteLine("-");
        }
        if (sign1 == -1 && sign2 == 1 && sign3 == 1)
        {
            Console.WriteLine("-");
        }
        if (sign1 == 1 && sign2 == -1 && sign3 == 1)
        {
            Console.WriteLine("-");
        }
        if (sign1 == 1 && sign2 == 1 && sign3 == -1)
        {
            Console.WriteLine("-");
        }
        if (sign1 == -1 && sign2 == -1 && sign3 == 1)
        {
            Console.WriteLine("+");
        }
        if (sign1 == -1 && sign2 == 1 && sign3 == -1)
        {
            Console.WriteLine("+");
        }
        if (sign1 == 1 && sign2 == -1 && sign3 == -1)
        {
            Console.WriteLine("+");
        }
        if (sign1 == 0 || sign2 == 0 || sign3 == 0)
        {
            Console.WriteLine("0");
        }
    }
}
