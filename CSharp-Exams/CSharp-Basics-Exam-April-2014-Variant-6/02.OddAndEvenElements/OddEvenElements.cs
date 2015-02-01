using System;

class OddEvenElements
{
    //You are given N numbers. Calculate the sum, min and max of its odd elements and sum, min and max of its even elements. 
    //Consider that the first element is odd, the second is even, etc.
    //Input
    //The input data should be read from the console. It will consists of exactly one line.
    //•	At the first line N numbers will be given, separated one from another by a single space.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //You have to print the output in a single line at the console in the following format:
    //•	OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…
    //Print the numbers in the output without any unneeded trailing zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00). In case the sum, the minimal or the maximal element cannot be calculated (due to missing data), print "No".
    //Constraints
    //•	All numbers in the input will be in the range [-1 000 000 … 1 000 000], with no more than 10 digits (total, before and after the decimal point). The decimal separator in the non-integer numbers will be '.' and the numbers will have up to 2 digits after the decimal separator.
    //•	The count N of the numbers in the input is in the range [0 … 1000].
    //•	All numbers in the output should be formatted without unneded trailing zeroes.
    //•	Allowed work time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        
        string input = Console.ReadLine();
        string[] nums = input.Split();
        if (input == "")//ако няма входни данни
        {
            // Known issue: split on empty string returns 1 token ""
            nums = new string[0];
        }
        decimal[] numbers = new decimal[nums.Length];
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = decimal.Parse(nums[i]);
            if (i % 2 == 0) // тук са обърнати, защото първият елемент се счита за нечетн
            {
                oddSum += numbers[i];
                if (numbers[i] < oddMin)
                {
                    oddMin = numbers[i];
                }
                if (numbers[i] > oddMax)
                {
                    oddMax = numbers[i];
                }
            }
            else
            {
                evenSum += numbers[i];
                if (numbers[i] < evenMin)
                {
                    evenMin = numbers[i];
                }
                if (numbers[i] > evenMax)
                {
                    evenMax = numbers[i];
                }
            }
        }
        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", 
                                                                (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                              (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}
