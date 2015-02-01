using System;

class Star
{
    //You will be given an integer N. Your task is to draw a star on the console. The width of the star is (2*N+1). The 
    //height of the star is (N*2 - (N/2-1)). The top and the middle part height is exactly (N/2). The height of the legs 
    //is (N/2+1). Check the examples below to understand your task better.
    //Input
    //The input data is read from the console. The number N stays alone at the first line. The input data will always be 
    //valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You must print at the console a star of size N following the formulas above and the examples below.
    //Constraints
    //•	N will be a number between 6 and 36 and will be an even number.
    //•	Allowed working time: 0.2 seconds. Allowed memory: 16 MB.
    // Example N = 6:
    //                  ......*......
    //                  .....*.*.....
    //                  ....*...*....
    //                  ****.....****
    //                  .*.........*.
    //                  ..*.......*..
    //                  ...*..*..*...
    //                  ..*..*.*..*..
    //                  .*..*...*..*.
    //                  ****.....****

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', N) + '*' + new string('.', N));
        for (int i = 1; i < N/2; i++)
        {
            Console.WriteLine(new string('.', N - i) + '*' + new string('.', 2 * i - 1) + '*' + new string('.', N - i));
        }
        Console.WriteLine(new string('*', N / 2 + 1) + new string('.', N - 1) + new string('*', N / 2 + 1));
        for (int i = 1; i < N / 2; i++)
        {
            Console.WriteLine(new string('.', i) + '*' + new string('.', (2 * N) + 1 - (2 * i) - 2) + '*' + new string('.', i));
        }
        Console.WriteLine(new string('.', N / 2) + '*' + new string('.', N / 2 - 1) + '*' + new string('.', N / 2 - 1) +
                                                                                                '*' + new string('.', N / 2));
        for (int i = 1; i < N / 2; i++)
        {
            Console.WriteLine(new string('.', N / 2 - i) + '*' + new string('.', N / 2 - 1) + '*' + new string('.', 2 * i - 1)
                                                        + '*' + new string('.', N / 2 - 1) + '*' + new string('.', N / 2 - i));
        }
        Console.WriteLine(new string('*', N / 2 + 1) + new string('.', N - 1) + new string('*', N / 2 + 1));
    }
}
