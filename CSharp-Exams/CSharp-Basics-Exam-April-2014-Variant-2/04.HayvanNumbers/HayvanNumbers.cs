using System;

class HayvanNumbers
{
    //Hayvan numbers are 9-digit numbers in format abcdefghi, such that their sub-numbers abc, def and ghi have a difference
    //diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi, where each digit
    //a, b, c, d, e, f, g, h and i is in range [5…9].
    //Your task is to write a program to print all Hayvan numbers for given sum and diff in increasing order.
    //Input
    //•	The input data should be read from the console.
    //•	The number sum stays at the first line.
    //•	The number diff stays at the second line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Print Hayvan numbers matching given difference diff and given sum of digits sum, in increasing order, each at a separate line. In case no Hayvan numbers exits, print “No”.
    //Constraints
    //•	The number sum will be a positive integer number in the range [0…100].
    //•	The number diff will be a positive integer number in the range [0…1000].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int def = 0;
        int ghi = 0;
        int count = 0;
        for (int abc = 555; abc <= 999; abc++)
        {
            def = abc + diff;
            ghi = def + diff;
            if (isAllowed(abc) && isAllowed(def) && isAllowed(ghi) && sumOfDigits(abc) + sumOfDigits(def) +
                    sumOfDigits(ghi) == sum && sumOfDigits(abc) <= sumOfDigits(def) && sumOfDigits(def) <= sumOfDigits(ghi))
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int sumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }

    private static bool isAllowed(int num)
    {
        while (num > 0)
        {
            if (num % 10 < 5)
            {
                return false;
            }
            num = num / 10;
        }
        return true;
    }
}
