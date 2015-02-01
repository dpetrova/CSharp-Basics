using System;

class Rocklq
{
    //You will be given an integer N. The width of the rocklq is (3*N). The height of the rocklq is (2*N).
    //Input
    //Input data is read from the console.
    //•	The number N stays alone at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You must print at the console a picture of size N following the formulas above and the examples below.
    //Constraints
    //•	N will be a number between 5 and 31 and will be an odd number.
    //•	Time limit: 0.25 seconds. Allowed memory: 16 MB.
    //Example N= 5: .....*****.....
    //              ...*.......*...
    //              .*...........*.
    //              *...*.....*...*
    //              *.*.*.....*.*.*
    //              ....*.....*....
    //              ...*.......*...
    //              ..*.........*..
    //              .*...........*.
    //              ***************

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int symbolsBefore = N;
        int symbolsMiddle = N;
        Console.WriteLine("{0}{1}{0}", new string('.', symbolsBefore), new string('*', symbolsMiddle));
        symbolsBefore = N - 2;
        symbolsMiddle = N + 2;
        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', symbolsBefore), new string('.', symbolsMiddle));
            symbolsBefore -= 2;
            symbolsMiddle += 4;
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', N - 2), new string('.', N), new string('.', N - 2));
        int symbolsBetween = 1;
        symbolsBefore = N - 4;
        symbolsMiddle = N;
        for (int i = 0; i < N / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', symbolsBefore), new string('.', symbolsBetween),
                                                                                             new string('.', symbolsMiddle));
            symbolsBefore -= 2;
            symbolsBetween += 2;
        }
        symbolsBefore = N - 1;
        symbolsMiddle = N;
        for (int i = 0; i < N -1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', symbolsBefore), new string('.', symbolsMiddle));
            symbolsBefore -= 1;
            symbolsMiddle += 2;
        }
        Console.WriteLine(new string('*', 3 * N));
    }
}
