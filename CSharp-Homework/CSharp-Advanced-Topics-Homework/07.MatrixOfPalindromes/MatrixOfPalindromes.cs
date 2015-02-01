using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("enter number of rows, number of columns:");
        string[] input = Console.ReadLine().Split();
        int r = int.Parse(input[0]);
        int c = int.Parse(input[1]);
        string[,] matrix = new string[r, c];
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col+row) + (char)('a' + row);
            }
        }
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}