using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score number in the range [1...9]:");
        int score = int.Parse(Console.ReadLine());
        int result = 0;
        if (score >= 1 && score <= 3)
        {
            result = score * 10;
            Console.WriteLine(result);
        }
        else if (score >= 4 && score <= 6)
        {
            result = score * 100;
            Console.WriteLine(result);
        }
        else if (score >= 7 && score <= 9)
        {
            result = score * 1000;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
