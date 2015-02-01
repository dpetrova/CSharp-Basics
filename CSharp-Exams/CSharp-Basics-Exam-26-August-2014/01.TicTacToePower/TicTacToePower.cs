using System;

class TicTacToePower
{
    //You are given tic-tac-toe board (3 columns and 3 rows) like the one the right. As inputs you will be given the X and Y 
    //coordinates of one of the cells. Each of the cells in the field has an index and a value (look at the examples on the 
    //right). You will be given the value of the first cell V (index1). Each of the next cells will have value greater by 1 
    //than the previous. Example: if value=80, then index1=80, index2=81, index3=82, ..., index9=89. Your task is to print 
    //on the console the value of the cell C raised to the power of its index: C index.
    //Input
    //The input data should be read from the console.
    //•	At the first line you will be given the X coordinate.
    //•	At the second line you will be given the Y coordinate.
    //•	At the third line an integer number V will be given, specifying the value of the first cell.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of 1 line:
    //•	Print the value C of the cell at position {X, Y} raised to the power of its index.
    //Constraints
    //•	The X and Y inputs will be integers in the range [0…2].
    //•	The V input will be an integer in the range [0…100].
    //•	Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        int[,] index = new int[3, 3];
        for (int i = 0; i < index.GetLength(0); i++)
        {
            for (int j = 0; j < index.GetLength(1); j++)
            {
                if (i == 0)
                {
                    index[i, j] = 1 + i + j;
                }
                else if (i == 1)
                {
                    index[i, j] = 3 + i + j;
                }
                else
                {
                    index[i, j] = 5 + i + j;
                }
            }
        }
        int[,] values = new int[3, 3];
        for (int i = 0; i < index.GetLength(0); i++)
        {
            for (int j = 0; j < index.GetLength(1); j++)
            {
                values[i, j] = (byte)(index[i, j] + V - 1);
            }
        }
        long result = (long)Math.Pow(values[Y, X], index[Y, X]); //here Y indicate rows; and X indicate columns
        Console.WriteLine(result);
        //for (int i = 0; i < index.GetLength(0); i++)
        //{
        //    for (int j = 0; j < index.GetLength(1); j++)
        //    {
        //        Console.Write(values[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
