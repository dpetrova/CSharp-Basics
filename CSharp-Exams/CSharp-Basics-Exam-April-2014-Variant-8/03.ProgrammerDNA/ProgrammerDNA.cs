using System;

class ProgrammerDNA
{
    //The secret scientists from the institute of Bizarre Artificial Neurobiology or B.A.N have tried for years to find
    //the DNA markers of the perfect programmer. The work is going well but after an incident with the printer in the institute
    //it is impossible to print the latest discovery. That is why they have asked you to help them.
    //Your task is to make a program that can print simple DNA chains of various lengths. Simple DNA chains consist of
    //sequence of diamond blocks containing only letters from A to G (see the example on the right).
    //Letters are chained alphabetically: A is followed by B, then C, D, E, F, G, then again A and so on. 
    //Each DNA block is with size 7.
    //Input
    //The input data should be read from the console.
    //•	On the first line an integer number N specifying the length of the DNA chain will be given.
    //•	On the second line the starting letter of the chain will be given (capital letter from A to G).
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Following the examples below print exactly N lines of the programmer's DNA. Use only capital letters from A to G and “.” for the empty space.
    //Constraints
    //•	N will always be a positive number between 7 and 999 inclusive.
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.
    //Example:       A
    //              BCD
    //             EFGAB
    //            CDEFGAB
    //             CDEFG
    //              ABC
    //               D
    //               E
    //              FGA
    //             BCDEF
    //            GABCDEF
    //             GABCD
    //              EFG
    //               A   


    static void Main()
    {
        int chainLength = int.Parse(Console.ReadLine());
        char inputChar = char.Parse(Console.ReadLine());
        int blockSize = 7;
        int midPoint = (blockSize / 2) + 1;
        int letterCount = 1;
        for (int i = 1; i <= chainLength; i++)
        {
            int dotsCount = (7 - letterCount) / 2;
            Console.Write(new string('.', dotsCount));
            for (int k = 0; k < letterCount; k++)
            {
                Console.Write(inputChar);
                // Change Letter
                if (inputChar == 'G')
                {
                    inputChar = 'A';
                }
                else
                {
                    inputChar++;
                }
            }
            Console.Write(new string('.', dotsCount));
            Console.WriteLine();

            if (i >= midPoint)
            {
                letterCount -= 2;
            }
            else
            {
                letterCount += 2;
            }
            if (i == blockSize)
            {
                letterCount = 1;
                blockSize += 7;
                midPoint += 7;
            }
        }
    }
}

