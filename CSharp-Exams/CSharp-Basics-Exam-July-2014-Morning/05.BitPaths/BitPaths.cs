using System;

class BitPaths
{
    //You are given a board of size 8 rows * 4 columns. It is initially empty (holds 0). A bit path starts at certain column
    //at the first row and falls 7 times either down left (direction = -1), down (direction = 0) or down right (direction = +1).
    //Bit paths invert all visited cells in the board (turns 0 to 1 and 1 to 0). Bit paths are represented as strings of 8 items,
    //separated by a comma: a start column + 7 directions. For example, the bit path "2,-1,-1,+1,-1,+1,+1,-1" starts from 
    //column 2 at the first row, moves to column 1 at the second row, then to column 0 at the third row, etc. The bit paths
    //will never go out of the board.
    //After the bit paths are processed, the bits of each board row are taken as binary number, converted to decimal, and then
    //summed. Finally, the obtained sum is printed in binary and hexadecimal form.
    //Input
    //The input data should be read from the console. The first line holds the number of paths n. The next n lines hold n paths
    //(in the above-described format). The input data will always be valid and in the format described.
    //Output
    //Print at the console two lines: the sum of board rows in binary and hexadecimal form.
    //Constraints
    //•	The count of paths n is an integer in the range [0…100].
    //•	The start positions are a positive numbers in the range [0…3]. 
    //•	The directions are one of the following values: -1, 0, +1.
    //•	Allowed working time: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        char[,] board = new char[8, 4];
        for (int j = 0; j < 8; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                board[j, k] = '0';
            }
        }
        for (int i = 0; i < n; i++)
        {
            string[] path = Console.ReadLine().Split(',');
            int row = 0;
            int col = int.Parse(path[0]);
            if (board[row, col] == '0')
            {
                board[row, col] = '1';
            }
            else
            {
                board[row, col] = '0';
            }

            for (int step = 1; step < path.Length; step++)
            {
                if (path[step] == "-1")
                {
                    row++;
                    col--;
                }
                else if (path[step] == "+1")
                {
                    row++;
                    col++;
                }
                else
                {
                    row++;
                }
                if (board[row, col] == '0')
                {
                    board[row, col] = '1';
                }
                else
                {
                    board[row, col] = '0';
                }
            }
        }

        int sum = 0;
        for (int k = 0; k < 8; k++)
        {
            string binaryNumber = "" + board[k, 0] + board[k, 1] + board[k, 2] + board[k, 3];
            int decimalNumber = Convert.ToInt32(binaryNumber, 2);
            sum += decimalNumber;
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }
}
