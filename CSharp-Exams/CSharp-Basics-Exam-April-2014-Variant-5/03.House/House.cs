using System;

class House
{
    //The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls 
    //and the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
    //You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from
    //the center (N+1)/2 and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between
    //the roofs’ end point and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.
    //Input
    //•	Input data is read from the console.
    //•	The number N stays alone at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You must print at the console a house of size N following the formulas above and the examples below.
    //Constraints
    //•	N will be an odd number between 5 and 49.
    //•	Time limit: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[,] house = new char[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == N / 2)
                {
                    house[i, j] = '*';
                }
                else
                {
                    house[i, j] = '.';
                }
            }
        }
        int row = 0;
        int col = N / 2;
        while (row < N / 2 && col >= 0)
        {
            house[row, col] = '*';
            row++;
            col--;
        }
        row = 0;
        col = N / 2;
        while (row < N / 2 && col <= N - 1)
        {
            house[row, col] = '*';
            row++;
            col++;
        }
        for (int i = (N + 1) / 2; i <= N - 2; i++)
        {
            house[i, N / 4] = '*';
            house[i, N - (N / 4) - 1] = '*';
        }
        for (int j = N / 4; j < N - (N / 4); j++)
        {
            house[N - 1, j] = '*';
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(house[i, j]);
            }
            Console.WriteLine();
        }
    }
}
