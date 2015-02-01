using System;

class WinningNumbers
{
    //We are given a string S consisting of capital and non-capital letters. Every letter has a value equal to its position
    //in the English alphabet (a=1, b=2, …, z=26). First you have to calculate the sum of all letters letSum. Then, find all
    //6-digits numbers in range [000 000 … 999 999] called winning numbers for which the following is true: the product of 
    //the first three digits is equal to the product of the second three digits, and both of those are equal to letSum. 
    //Your task is to print on the console all winning numbers.
    //Input
    //The input data should be read from the console. It consists of 1 line:
    //•	On the first line you will be given a string S which will only consist of lower and capital case letters.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console as a sequence of winning numbers in format abc-def in ascending order. Each winning number should stay alone on a separate line. In case there are no winning numbers, print “No”.
    //Constraints
    //•	The string S will have maximal length of 150 characters.
    //•	Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        string str = Console.ReadLine();
        str = str.ToLower();
        int letSum = 0;
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            letSum += (str[i] - 96);
        }
        for (int i = 100; i <= 999; i++)
        {
            for (int j = 100; j < 999; j++)
            {
                if (CalcProduct(i) == letSum && CalcProduct(j) == letSum)
                {
                    Console.WriteLine("{0}-{1}", i, j);
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcProduct(int number)
    {
        int product = 1;
        while (number > 0)
        {
            product *= number % 10;
            number /= 10;
        }
        return product;
    }
}
