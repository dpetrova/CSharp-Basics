using System;
using System.Collections.Generic;

class MorseCodeNumbers
{
    //"Morse code" is a method of transmitting text information as a series of on-off tones / lights / clicks / etc. 
    //All symbols are represented by “.” (dots) and “-“ (dashes).
    //You are given a 4-digit number n (1000 ≤ n ≤ 9999). First, you have to calculate the sum of all digits of the 
    //number n called nSum. Write a program to generate all sequences of 6 numbers in the range 0…5, represented by their
    //Morse code encodings (0 = “-----”, 1 = “.----”, 2 = “..---”, 3 = “...--”, 4 = “....-”, 5 = “.....”), such that the
    //product of these 6 numbers is equal to nSum. This product is called morseProduct. Put “|” (pipe) as a separator after
    //each Morse code digit. These sequences of strings are called “Morse code numbers”. See the examples below for better
    //understanding.
    //Input
    //•	The input data should be read from the console.
    //•	The number n stays at the first line.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console as a sequence of strings (Morse code numbers), each at a separate line. The order of the output lines is not important. In case no Morse code numbers exist, print “No”.
    //Constraints
    //•	The number n will be an integer number in the range [1000…9999].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    public static bool foundAnswer = false;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            nSum += digit;
            n = n / 10;
        }
        for (int number = 100000; number < 555555; number++)
        {
            CheckMorseProduct(number, nSum);
        }
        if (!foundAnswer)
        {
            Console.WriteLine("No");
        }

    }

    private static bool IsAllowedNumber(int number)
    {
        string num = number.ToString();
        foreach (var digit in num)
        {
            if (digit > '5')
            {
                return false;
            }
        }
        return true;
    }

    private static void CheckMorseProduct(int number, int nSum)
    {
        
        if (IsAllowedNumber(number))
        {
            int morseProduct = 1;
            List<int> digits = new List<int>();
            while (number > 0)
            {
                int digit = number % 10;
                morseProduct *= digit;
                digits.Add(digit);
                number = number / 10;
            }
            if (morseProduct == nSum)
            {
                foundAnswer = true;
                for (int i = 0; i < digits.Count; i++)
                {
                    switch (digits[i])
                    {
                        case 0: Console.Write("-----|"); break;
                        case 1: Console.Write(".----|"); break;
                        case 2: Console.Write("..---|"); break;
                        case 3: Console.Write("...--|"); break;
                        case 4: Console.Write("....-|"); break;
                        case 5: Console.Write(".....|"); break;
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
