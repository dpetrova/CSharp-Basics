using System;

class Arrow
{
    //SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it. Your task is to print
    //a vertical arrow, which will be used to indicate the path to the new building in the city.
    //Input
    //The input data should be read from the console.
    //•	On the only line will hold and integer number N (always odd number), indicating the width of the arrow. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Use the “#” (number sign) to mark the arrow and “.” (dot) for the rest. Follow the examples below.
    //Constraints
    //•	N will always be a positive odd number between 3 and 79 inclusive.
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.
    // Example N=5: ..#####..
    //              ..#...#..
    //              ..#...#..
    //              ..#...#..
    //              ###...###
    //              .#.....#.
    //              ..#...#..
    //              ...#.#...
    //              ....#....


    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        string outerDots = new string('.', N / 2);
        string innerDots = new string('.', N - 2);
        string baseNumberSign = new string('#', N);
        string arrowNumberSign = new string('#', N / 2 + 1);
        string spade = new string('.', N-1);
        Console.WriteLine(outerDots + baseNumberSign + outerDots);
        for (int i = 0; i < N-2; i++)
        {
            Console.WriteLine(outerDots + '#' + innerDots + '#' + outerDots);
        }
        Console.WriteLine(arrowNumberSign + innerDots + arrowNumberSign);
        for (int i = 1; i <= N - 2; i++)
        {
            string arrowOuterDots = new string('.', i);
            string arrowInnerDots = new string('.', 2 * N - 1 - 2 * (i + 1));
            Console.WriteLine(arrowOuterDots + '#' + arrowInnerDots + '#' + arrowOuterDots);
        }
        Console.WriteLine(spade + '#' + spade);
    }
}
