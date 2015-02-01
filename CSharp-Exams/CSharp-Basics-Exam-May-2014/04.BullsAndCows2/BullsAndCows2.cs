using System;

class BullsAndCows2
{
    //All we love the “Bulls and Cows” game (http://en.wikipedia.org/wiki/Bulls_and_cows). Given a 4-digit secret number and
    //a 4-digit guess number we say that we have b bulls and c cows when we have b matching digits on their right positions
    //(bulls) and c matching digits on different positions (cows). Examples are given below:
    //Secret number	1	4	8	1	Bulls  = 1
    //Guess number	8	8	1	1   Cows = 2
    //
    //Secret number	2	2	4	9	Bulls  = 0
    //Guess number	9	9	2	4   Cows = 3

    //Given the secret number and the number of bulls and cows your task is to write a program to find all matching guess 
    //numbers in increasing order.
    //Input
    //•	The input data should be read from the console.
    //•	It will consist of exactly 3 lines. At the first line there the secret number will be given. At the second line the number of bulls b will be given. At the third line the number of cows c will be given.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data should be printed on the console
    //•	It should consist of a single line holding all matched guess numbers, given in increasing order, separated by single space.
    //Constraints
    //•	The secret number will always consist of exactly 4 digits, each in the range [1…9].
    //•	The numbers b and c will be in the range [0…9].
    //•	Time limit: 0.15 seconds.
    //•	Allowed memory: 4 MB.

    static void Main()
    {
        string guessNum = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        bool solutionFound = false;

        // Check all possible 4-digit numbers
        for (int candidate = 1111; candidate <= 9999; candidate++)
        {
            char[] digits = candidate.ToString().ToCharArray();
            if (digits[0] >= '1' && digits[1] >= '1' && digits[2] >= '1' && digits[3] >= '1')
            {
                char[] guess = guessNum.ToCharArray();
                int bulls = 0;
                int cows = 0;

                // Count the bulls and mark them as unavailable
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == digits[i])
                    {
                        bulls++;
                        guess[i] = '*';
                        digits[i] = '@';
                    }
                }

                // Count the cows and mark them as unavailable
                for (int guessIndex = 0; guessIndex < guess.Length; guessIndex++)
                {
                    for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                    {
                        if (guess[guessIndex] == digits[digitsIndex])
                        {
                            cows++;
                            guess[guessIndex] = '*';
                            digits[digitsIndex] = '@';
                        }
                    }
                }

                // Print the configuration if the bulls and cows match the target
                if (bulls == targetBulls && cows == targetCows)
                {
                    if (solutionFound)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(candidate);
                    solutionFound = true;
                }
            }
        }

        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    }
}
