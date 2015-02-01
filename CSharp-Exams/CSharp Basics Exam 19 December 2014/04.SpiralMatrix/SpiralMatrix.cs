using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string keyword = input.ToLower();
        char[] letters = keyword.ToCharArray();
        char[,] matrix = new char[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        for (int i = 0; i < n * n; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++; 
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right"; 
                row++;
                col++;
            }

            matrix[row, col] = letters[i % letters.Length]; 

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        int maxSumRows = 0;
        int sumRows = 0;
        int rowIndex = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumRows += (int)(matrix[i, j] % 96) * 10;
            }
            if (maxSumRows < sumRows)
            {
                maxSumRows = sumRows;
                rowIndex = i;
            }
            sumRows = 0;
        }

        Console.WriteLine("{0} - {1}", rowIndex, maxSumRows);

    }
}
