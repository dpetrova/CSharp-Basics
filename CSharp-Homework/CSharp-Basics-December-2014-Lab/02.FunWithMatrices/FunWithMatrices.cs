using System;

class FunWithMatrices
{
    static void Main()
    {
        double startNumber = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        double[,] matrix = new double[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix[i, j] = startNumber;
                startNumber += step;
            }
        }
        string input = Console.ReadLine();
        while (input != "Game Over!")
        {
            string[] commands = input.Split();
            int row = int.Parse(commands[0]);
            int col = int.Parse(commands[1]);
            double num = double.Parse(commands[3]);
            if (commands[2] == "multiply")
            {
                matrix[row, col] *= num;
            }
            else if (commands[2] == "sum")
            {
                matrix[row, col] += num;
            }
            else if (commands[2] == "power")
            {
                matrix[row, col] = Math.Pow(matrix[row, col], num);
            }
            input = Console.ReadLine();
        }
        double maxSumRows = 0;
        double sumRows = 0;
        int rowIndex = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sumRows += matrix[row, col];
            }
            if (maxSumRows < sumRows)
            {
                maxSumRows = sumRows;
                rowIndex = row;
            }
            sumRows = 0;
        }

        double maxSumColumn = 0;
        double sumColumn = 0;
        int columnIndex = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumColumn += matrix[row, col];
            }
            if (maxSumColumn < sumColumn)
            {
                maxSumColumn = sumColumn;
                columnIndex = col;
            }
            sumColumn = 0;
        }

        double sumLeftDiagonal = 0;
        int c1 = 0;
        int c2 = 0;
        while (c1 <= 3 && c2 <= 3)
        {
            sumLeftDiagonal += matrix[c1, c2];
            c1++;
            c2++;
        }

        double sumRightDiagonal = 0;
        c1 = 0;
        c2 = 3;
        while (c1 <= 3 && c2 >= 0)
        {
            sumRightDiagonal += matrix[c1, c2];
            c1++;
            c2--;
        }

        if (maxSumRows >= maxSumColumn && maxSumRows >= sumLeftDiagonal && maxSumRows >= sumRightDiagonal)
        {
            Console.WriteLine("ROW[{0}] = {1:0.00}", rowIndex, maxSumRows);
        }
        else if (maxSumColumn > maxSumRows && maxSumColumn >= sumLeftDiagonal && maxSumColumn >= sumRightDiagonal)
        {
            Console.WriteLine("COLUMN[{0}] = {1:0.00}", columnIndex, maxSumColumn);
        }
        else if (sumLeftDiagonal > maxSumRows && sumLeftDiagonal > maxSumColumn && sumLeftDiagonal >= sumRightDiagonal)
        {
            Console.WriteLine("LEFT-DIAGONAL = {0:0.00}", sumLeftDiagonal);
        }
        else if (sumRightDiagonal > maxSumRows && sumRightDiagonal > maxSumColumn && sumRightDiagonal > sumLeftDiagonal)
        {
             Console.WriteLine("RIGHT-DIAGONAL = {0:0.00}", sumRightDiagonal);
        }
    }
}
