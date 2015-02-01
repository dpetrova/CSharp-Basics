using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', diameter / 2) + new string('*', diameter + 2) + new string('-', diameter / 2));
        for (int i = 0; i < diameter; i++)
        {
            Console.WriteLine(new string('-', diameter / 2) + '*' + new string('-', diameter) + '*' 
                                                                            + new string('-', diameter / 2));
        }
        for (int i = 3; i < diameter + 1; i+=2)
        {
            int dashesCount = (diameter - i) / 2;
            Console.WriteLine(new string('-', dashesCount) + new string('*', i) + new string('-', (2 * dashesCount) + 1)
                                                                    + new string('*', i) + new string('-', dashesCount));
        }
        for (int i = diameter-2; i > 0; i-=2)
        {
            int dashesCount = (diameter - i) / 2;
            Console.WriteLine(new string('-', dashesCount) + new string('*', i) + new string('-', (2 * dashesCount) + 1)
                                                                    + new string('*', i) + new string('-', dashesCount));
        }
    }
}
