using System;

class HouseWithAWindow
{
    //Write a program to print at the console a house of given size N. The roof is a triangle. The walls are straight vertical
    //lines. The base is a straight horizontal line. The roof, the walls, the window and the base of the house it build of '*'.
    //Everything else is filled with '.' (see the examples below).
    //You will be given an integer N (N % 4 = 0). The width of the house is (2*N-1), the height of the house is (2*N+2). 
    //The height of the roof is exactly N lines. The base of the house height is (N+2). The window height is always (N/2). 
    //The window width is (N-3). See the examples below to understand better these formulas.
    //Input
    //•	The input data is read from the console.
    //•	The number N stays alone at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You should print the house on the console, just like in the examples below. Each row can contain only the following
    //characters: “.” (dot) and “*” (asterisk).
    //Constraints
    //•	N will be an integer number between 4 and 120 and will always be divided by 4 without reminder.
    //•	Time limit: 0.25 seconds. Allowed memory: 16 MB.
    // Example N = 8:   .......*.......
    //                  ......*.*......
    //                  .....*...*.....
    //                  ....*.....*....
    //                  ...*.......*...
    //                  ..*.........*..
    //                  .*...........*.
    //                  *.............*
    //                  ***************
    //                  *.............*
    //                  *.............*
    //                  *....*****....*
    //                  *....*****....*
    //                  *....*****....*
    //                  *....*****....*
    //                  *.............*
    //                  *.............*
    //                  ***************


    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        //draw all house as a matrix of '.'
        char[,] house = new char[2 * N + 2, 2 * N - 1];
        for (int i = 0; i < house.GetLength(0); i++)
        {
            for (int j = 0; j < house.GetLength(1); j++)
            {
                house[i, j] = '.';
            }
        }
        //draw left part of the roof
        int row = 0;
        int col = N - 1;
        while (row <= N && col >= 0)
        {
            house[row, col] = '*';
            row++;
            col--;
        }
        //draw right part of the roof
        row = 0;
        col = N - 1;
        while (row < N && col <= 2 * N)
        {
            house[row, col] = '*';
            row++;
            col++;
        }
        //draw eaves of the house
        row = N;
        col = 0;
        while (col < 2 * N - 1)
        {
            house[row, col] = '*';
            col++;
        }
        //draw left wall of the house
        row = N + 1;
        col = 0;
        while (row <= 2 * N + 1)
        {
            house[row, col] = '*';
            row++;
        }
        //draw right wall of the house
        row = N + 1;
        col = 2 * N - 2;
        while (row <= 2 * N + 1)
        {
            house[row, col] = '*';
            row++;
        }
        //draw window
        for (int i = N + 1 + N/4; i < N + 1 + N/4 + N/2; i++)
        {
            for (int j = N/2 + 1; j < N/2 + 1 + N - 3; j++)
            {
                house[i, j] = '*';
            }
        }
        //draw base of the house
        row = 2 * N + 1;
        col = 0;
        while (col < 2 * N - 1)
        {
            house[row, col] = '*';
            col++;
        }

        //print the house at the console
        for (int i = 0; i < house.GetLength(0); i++)
        {
            for (int j = 0; j < house.GetLength(1); j++)
            {
                Console.Write(house[i, j]); ;
            }
            Console.WriteLine();
        }
    }
}
