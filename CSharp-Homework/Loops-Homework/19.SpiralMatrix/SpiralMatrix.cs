using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("enter a positive integer number n (1 <= n <= 20):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0; //initial position of the matrix rows
        int col = 0; //initial position of the matrix columns

        string direction = "right"; //start direction of moving
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0)) //check if the moving right is otside the matrix (col > n-1) or comes to already filled position (matrix[row,col] != 0)
            {
                direction = "down"; //change position to down
                col--; //turn one position left
                row++; //moves down
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0)) //check if the moving right is otside the matrix (row > n-1) or comes to already filled position (matrix[row,col] != 0)
            {
                direction = "left"; //change position to left
                row--; //turn one position up
                col--; //moves left
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0)) //check if the moving right is otside the matrix (col < 0) or comes to already filled position (matrix[row,col] != 0)
            {
                direction = "up"; //change position to up
                col++; //turn one position right
                row--; //moves up
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0)) //check if the moving right is otside the matrix (row < 0) or comes to already filled position (matrix[row,col] != 0)
            {
                direction = "right"; //change direction to right
                row++; //turn one position down
                col++; //moves right
            }

            matrix[row, col] = i; //fills numbers in the matrix

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

        // Display Matrix
        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,4}", matrix[k, l]);
            }
            Console.WriteLine();
        }
    }
}
