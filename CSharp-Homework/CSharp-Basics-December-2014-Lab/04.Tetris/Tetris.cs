using System;

class Tetris
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split();
        int rows = int.Parse(dimensions[0]);
        int columns = int.Parse(dimensions[1]);
        char[,] field = new char[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            string input = Console.ReadLine();
            input.ToCharArray();
            for (int j = 0; j < columns; j++)
            {
                field[i, j] = input[j];
            }
        }
        int countL = 0;
        int countJ = 0;
        int countO = 0;
        int countI = 0;
        int countZ = 0;
        int countS = 0;
        int countT = 0;

        //check for I
        for (int i = 0; i < field.GetLength(0) - 3; i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                if (field[i, j] == 'o' && field[i + 1, j] == 'o' && field[i + 2, j] == 'o' && field[i + 3, j] == 'o')
                {
                    countI++;                    
                }
            }
        }
        Console.Write("I:{0}, ", countI);
                
        //check for L
        for (int i = 0; i < field.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < field.GetLength(1) - 1; j++)
            {
                if (field[i, j] == 'o' && field[i + 1, j] == 'o' && field[i + 2, j] == 'o' && field[i + 2, j + 1] == 'o')
                {
                    countL++;                    
                }
            }
        }
        Console.Write("L:{0}, ", countL);

        //check for J
        for (int i = 0; i < field.GetLength(0) - 2; i++)
        {
            for (int j = 1; j < field.GetLength(1); j++)
            {
                if (field[i, j] == 'o' && field[i + 1, j] == 'o' && field[i + 2, j] == 'o' && field[i + 2, j - 1] == 'o')
                {
                    countJ++;                    
                }
            }
        }
        Console.Write("J:{0}, ", countJ);

        //check for O
        for (int i = 0; i < field.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < field.GetLength(1) - 1; j++)
            {
                if (field[i, j] == 'o' && field[i + 1, j] == 'o' && field[i, j + 1] == 'o' && field[i + 1, j + 1] == 'o')
                {
                    countO++;                    
                }
            }
        }
        Console.Write("O:{0}, ", countO);
        
        //check for Z
        for (int i = 0; i < field.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < field.GetLength(1) - 2; j++)
            {
                if (field[i, j] == 'o' && field[i, j + 1] == 'o' && field[i + 1, j + 1] == 'o' && field[i + 1, j + 2] == 'o')
                {
                    countZ++;                    
                }
            }
        }
        Console.Write("Z:{0}, ", countZ);

        //check for S
        for (int i = 1; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1) - 2; j++)
            {
                if (field[i, j] == 'o' && field[i, j + 1] == 'o' && field[i - 1, j + 1] == 'o' && field[i - 1, j + 2] == 'o')
                {
                    countS++;                    
                }
            }
        }
        Console.Write("S:{0}, ", countS);

        //check for T
        for (int i = 0; i < field.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < field.GetLength(1) - 2; j++)
            {
                if (field[i, j] == 'o' && field[i, j + 1] == 'o' && field[i, j + 2] == 'o' && field[i + 1, j + 1] == 'o')
                {
                    countT++;                    
                }
            }
        }
        Console.Write("T:" + countT);
        Console.WriteLine();

    }
}
