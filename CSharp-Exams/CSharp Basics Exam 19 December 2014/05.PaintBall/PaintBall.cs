using System;

class PaintBall
{
    static void Main()
    {
        char[,] canvas = new char[10, 10];
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                canvas[i, j] = '1';
            }
        }

        string input = Console.ReadLine();
        int ball = 1;
        while (input != "End")
        {
            string[] commands = input.Split();
            int row = int.Parse(commands[0]);
            int col = 9 - int.Parse(commands[1]);
            int radius = int.Parse(commands[2]);
            int rowStart = row - radius;
            int rowEnd = row + radius;
            int colStart = col - radius;
            int colEnd = col + radius;
            if (rowStart < 0)
            {
                rowStart = 0;
            }
            if (rowEnd > 9)
            {
                rowEnd = 9;
            }
            if (colStart < 0)
            {
                colStart = 0;
            }
            if (colEnd > 9)
            {
                colEnd = 9;
            }

            for (int i = rowStart; i <= rowEnd; i++)
            {
                for (int j = colStart; j <= colEnd; j++)
                {
                    if (ball % 2 != 0)
                    {
                        canvas[i, j] = '0';
                    }
                    else
                    {
                        canvas[i, j] = '1';
                    }
                }
            }

            //for (int k = 0; k < canvas.GetLength(0); k++)
            //{
            //    for (int l = 0; l < canvas.GetLength(1); l++)
            //    {
            //        Console.Write("{0,4}", canvas[k, l]);
            //    }
            //    Console.WriteLine();
            //}

            ball++;
            input = Console.ReadLine();
        }

        long sum = 0;
        string numberAsString = "";
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                numberAsString += canvas[i, j];
            }
            //Console.WriteLine(numberAsString);
            long number = Convert.ToInt64(numberAsString, 2);
            sum += number;
            numberAsString = "";
        }

        Console.WriteLine(sum);

        
    }
}
