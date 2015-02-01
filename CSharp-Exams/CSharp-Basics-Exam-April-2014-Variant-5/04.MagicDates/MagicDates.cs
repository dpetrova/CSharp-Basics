using System;

class MagicDates
{
    //Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the weight of this date by joining together
    //all its digits, multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will
    //have 8-digits: 17032007, so the weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 +
    //0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
    //Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. 
    //The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months,
    //each having 28, 29, 30 or 31 days, etc.). Years start from 1 January and end in 31 December.
    //Input
    //The input data should be read from the console. It consists of 3 lines:
    //•	The first line holds an integer number – start year.
    //•	The second line holds an integer number – end year.
    //•	The third line holds an integer number – magic weight.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console as a sequence of dates in format dd-mm-yyyy in alphabetical order. Each string should stay on a separate line. In case no magic dates exist, print “No”.
    //Beware that the regional settings at your computer and at the judge's computer may be different!
    //Constraints
    //•	The start and end year are integers in the range [1900-2100].
    //•	The magic weight is an integer number in range [1…1000].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        DateTime start = new DateTime(startYear, 1, 1);
        DateTime end = new DateTime(endYear, 12, 31);
        int count = 0;
        for (DateTime i = start; i <= end; i = i.AddDays(1))
        {
            int i1 = i.Day / 10; // it is the first digit of the day from the date, for example 02/12/2014 -> 0 = 02/10
            int i2 = i.Day % 10; // it is the second digit of the day from the date, for example 02/12/2014 -> 2 = 02%10
            int i3 = i.Month / 10; // it is the first digit of the month from the date, for example 02/12/2014 -> 1 = 12/10
            int i4 = i.Month % 10; // it is the second digit of the month from the date, for example 02/12/2014 -> 2 = 12%10
            int i5 = i.Year / 1000; // it is the first digit of the year from the date, for example 02/12/2014 -> 2 = 2014/1000
            int i6 = (i.Year / 100) % 10; // it is the second digit of the year from the date, for example 02/12/2014 -> 0 = (2014/100)%10
            int i7 = (i.Year / 10) % 10; // it is the third digit of the year from the date, for example 02/12/2014 -> 1 = (2014/10)%10
            int i8 = i.Year % 10; // it is the fourth digit of the year from the date, for example 02/12/2014 -> 4 = 2014%10
            int[] digits = { i1, i2, i3, i4, i5, i6, i7, i8 };
            int weight = 0;
            for (int j = 0; j < digits.Length; j++)
            {
                for (int k = j + 1; k < digits.Length; k++)
                {
                    weight += digits[j] * digits[k];
                }
            }
            if (weight == magicWeight)
            {
                Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", i.Day, i.Month, i.Year);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
