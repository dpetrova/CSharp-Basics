using System;

class FibbonachiNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long previousMember = 0;
        long nextMember = 1;
        long sum;
        if (n == 1)
        {
            Console.WriteLine(previousMember);
        }
        else
        {
            Console.Write("{0} {1}", previousMember, nextMember);
        }
        for (int i = 0; i < n - 2; i++) //n-2, защото първите два члена не ги изчислява в цикъла
        {
            sum = previousMember + nextMember;
            previousMember = nextMember;
            nextMember = sum;
            Console.Write(" {0}", nextMember);
        }
    }
}
