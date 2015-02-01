﻿using System;

class MagicString
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

    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 'k', 'n', 'p', 's' };
        int counter = 0;
        for (int d1 = 0; d1 < letters.Length; d1++)
        {
            for (int d2 = 0; d2 < letters.Length; d2++)
            {
                for (int d3 = 0; d3 < letters.Length; d3++)
                {
                    for (int d4 = 0; d4 < letters.Length; d4++)
                    {
                        string num1 = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4];
                        int weightNum1 = WeightOfLetters(num1);
                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            for (int d6 = 0; d6 < letters.Length; d6++)
                            {
                                for (int d7 = 0; d7 < letters.Length; d7++)
                                {
                                    for (int d8 = 0; d8 < letters.Length; d8++)
                                    {
                                        string num2 = "" + letters[d5] + letters[d6] + letters[d7] + letters[d8];
                                        int weightNum2 = WeightOfLetters(num2);
                                        if (Math.Abs(weightNum1 - weightNum2) == diff)
                                        {
                                            Console.WriteLine("{0}{1}", num1, num2);
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int WeightOfLetters(string str)
    {
        int weight = 0;
        int num = 0;
        foreach (var letter in str)
        {
            switch (letter)
            {
                case 'k':
                    num = 1;
                    break;
                case 'n':
                    num = 4;
                    break;
                case 'p':
                    num = 5;
                    break;
                case 's':
                    num = 3;
                    break;
            }
            weight = weight + num;
        }
        return weight;
    }
}
