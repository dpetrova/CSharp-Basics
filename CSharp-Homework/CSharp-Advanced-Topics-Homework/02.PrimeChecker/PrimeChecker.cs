using System;

class PrimeChecker
{
    static void Main()
    {
        ulong n;
        bool isUlong = ulong.TryParse(Console.ReadLine(), out n);
        if (isUlong)
        {
            IsPrime(n);
        }
        else
        {
            Console.WriteLine("it is a not positive integer");
        }
    }

    static void IsPrime(ulong n)
    {
        bool isPrime = true;
        if (n == 0 || n == 1)
        {
            isPrime = false;
        }
        else
        {
            ulong counter = 2;
            while (counter <= (ulong)Math.Sqrt(n))
            {
                if (n % counter == 0)
                {
                    isPrime = false;
                }
                counter++;
            }
        }
        Console.WriteLine(isPrime);
    }
}