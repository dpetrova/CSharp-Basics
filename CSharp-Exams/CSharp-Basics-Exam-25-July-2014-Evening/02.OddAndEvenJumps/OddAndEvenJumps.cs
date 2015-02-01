using System;
using System.Collections.Generic;

class OddAndEvenJumps
{
    //We are given an input string, e.g. "Software University". We take its odd and even letters, turned into lowercase:
    //•	odd letters -> "sfwruiest"
    //•	even letters -> "otaenvriy"
    //We are also given two numbers: oddJump and evenJump. We pass through the odd letters from left to right and we sum their
    //ASCII codes and aggregate the sum to the result (initially starting form 0). Through a step of oddJump we multiply the
    //current result by the ASCII code of the current letter instead of adding it to the result. Finally we print the result
    //as hexadecimal number. We do the same for the even letters with a step of evenJump. For our example, let's assume 
    //oddJump = 3 and evenJump = 2. The calculations are performed as follows:
    //•	odd result = ( ( (+ 115 's' + 102 'f') * 119 'w' + 114 'r' + 117 'u' ) * 105 'i' + 101 'e' + 115 's' ) * 116 't' = 317362776 = 12EA9258 (hex)
    //•	even result = ( ( + 111 'o' * 116 't' + 97 'a' ) * 101 'e' + 110 'n' ) * 118 'v' + 114 'r' ) * 105 'i' + 121 'y' = 16235657461 = 3C7B878F5 (hex)
    //Input
    //The input data should be read from the console. It consists of 3 lines:
    //•	The first line holds the input string.
    //•	The second line holds the number oddJump.
    //•	The third line holds the number evenJump.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should consist of 2 lines:
    //•	The odd result in hexadecimal form in format: „Odd: XXX“.
    //•	The even result in hexadecimal form in format: „Even: XXX“.
    //Constraints
    //•	The input string will consist of only Latin letters and spaces in the range [1…100].
    //•	The numbers oddJump and evenJump will be integer in the range [1…100].
    //•	The odd and even results will be in the range [0…7FFF FFFF FFFF FFFF].
    //•	Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToLower().Replace(" ", "");
        byte oddJump = byte.Parse(Console.ReadLine());
        byte evenJump = byte.Parse(Console.ReadLine());
        List<char> oddLetters = new List<char>();
        List<char> evenLettes = new List<char>();
        for (int i = 0; i < input.Length; i += 2)
        {
            oddLetters.Add(input[i]);
        }
        for (int j = 1; j < input.Length; j += 2)
        {
            evenLettes.Add(input[j]);
        }
        ulong oddResult = 0;
        ulong evenResult = 0;
        for (int i = 0; i < oddLetters.Count; i++)
        {
            if ((i + 1) % oddJump == 0)
            {
                oddResult *= oddLetters[i];
            }
            else
            {
                oddResult += oddLetters[i];
            }
        }
        for (int j = 0; j < evenLettes.Count; j++)
        {
            if ((j + 1) % evenJump == 0)
            {
                evenResult *= evenLettes[j];
            }
            else
            {
                evenResult += evenLettes[j];
            }
        }
        Console.WriteLine("Odd: {0:X}", oddResult);
        Console.WriteLine("Even: {0:X}", evenResult);
    }
}
