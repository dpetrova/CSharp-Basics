using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a positive integer number ≤ 100:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number > 100)
        {
            Console.WriteLine("out of range");
        }
        else if (number <= 1)
        {
            Console.WriteLine("Prime? {0}", !isPrime);
        }
        else
        {
            int counter = 2;
            while (counter <= Math.Sqrt(number))
            {
                if (number % counter == 0)
                {
                    isPrime = false;
                    break;
                }
                counter++;
            }
            Console.WriteLine("Prime? {0}", isPrime);
        }
    }
}
