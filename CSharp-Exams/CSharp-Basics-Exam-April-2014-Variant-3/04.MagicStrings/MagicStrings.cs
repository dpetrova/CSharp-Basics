using System;

class MagicStrings
{
    //You are given a number diff. Write a program to generate all sequences of 8 letters, each from the set
    //{ 's', 'n', 'k', 'p' }, such that the weight of the first 4 letters differs from the weight of the second 4 letters
    //exactly by diff. These sequences are called “magic strings”. Print them in alphabetical order.
    //The weight of a single letter is calculated as follows:  weight('s') = 3; weight('n') = 4;  weight('k') = 1;
    //weight('p') = 5. The weight of a sequence of 4 letters is the calculated as sum of the weights of these 4 individual letters.
    //Input
    //•	The input data should be read from the console.
    //•	The number diff stays at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console as a sequence of strings in alphabetical order. Each string should stay on a separate line. In case no magic strings exist, print “No”.
    //Constraints
    //•	The number diff will be an integer number in the range [0…100].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    //ПРОГРАМАТА РАБОТИ, НО НАДХВЪРЛЯ ЛИМИТА ОТ ВРЕМЕ!!!!!!!

    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        int count = 0;
        for (int num1 = 1111; num1 <= 5555; num1++)
        {
            for (int num2 = 1111; num2 <= 5555; num2++)
            {
                if (IsAllowedLetter(num1) && IsAllowedLetter(num2) &&
                                Math.Abs(CalcSumOfLetters(num1) - CalcSumOfLetters(num2)) == diff)
                {
                    string str1 = num1.ToString();
                    string str2 = num2.ToString();
                    string letterString1 = str1.Replace('3', 's').Replace('4', 'n').Replace('1', 'k').Replace('5', 'p');
                    string letterString2 = str2.Replace('3', 's').Replace('4', 'n').Replace('1', 'k').Replace('5', 'p');
                    Console.WriteLine("{0}{1}", letterString1, letterString2);
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcSumOfLetters(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum = sum + (num % 10);
            num = num / 10;
        }
        return sum;
    }

    private static bool IsAllowedLetter(int num)
    {
        string digits = num.ToString();
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '5' || digit == '2')
            {
                return false;
            }
        }
        return true;
    }

    //private static bool IsAllowedLetter(int num)
    //{
    //while (num > 0)
    //{
    //    if (num % 10 < '1' || num % 10 > '5' || num % 10 == '2')
    //    {
    //        return false;
    //    }
    //}
    //return true;
}
