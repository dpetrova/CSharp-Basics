using System;

class NineDigitMagicNumbers
{
    //You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi,
    //such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is
    //sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic numbers”.
    //Your task is to write a program to print these numbers in increasing order.
    //Input
    //•	The input data should be read from the console.
    //•	The number sum stays at the first line.
    //•	The number diff stays at the second line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Print all nine-digit magic numbers matching given difference diff and given sum of digits sum, in increasing order, each at a separate line. In case no nine-digit magic numbers exits, print “No”.
    //Constraints
    //•	The number sum will be a positive integer number in the range [0…100].
    //•	The number diff will be a positive integer number in the range [0…1000].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int resultsCount = 0;
        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;
            if (IsAllowedNumber(num1) && IsAllowedNumber(num2) && IsAllowedNumber(num3) &&
                               CalcSumOfDigits(num1) + CalcSumOfDigits(num2) + CalcSumOfDigits(num3) == sum &&
                                        num1 <= num2 && num2 <= num3 && (num3 <= 777))
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0) //while finish all digits
        {
            sum += num % 10; //starts sum from last digit to first: (num % 10) is the last digit
            num = num / 10; //remove last digit
        }
        return sum;
    }

    private static bool IsAllowedNumber(int num)
    {
        string digits = num.ToString(); //convert numbers num1, num2, num3 into strings
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7') //digit are only from 1 to 7
            {
                return false;
            }
        }
        return true;
    }
}