using System;

class TheExplorer
{
    //Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. 
    //Today he is going on an expedition to collect all kind of diamonds, no matter small or large. 
    //Help your friend to find all the diamonds in the biggest known cave "The Console Cave". 
    //At the only input line you will be given the width of the diamond. The char that forms the outline of the diamonds
    //is '*' and the surrounding parts are made of '-' (see the examples). Your task is to print a diamond of given size n.
    //Input
    //Input data should be read from the console. 
    //•	The only input line will hold the width of the diamond – n.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console.
    //•	The output lines should hold the diamond.
    //Constraints
    //•	The number n is positive odd integer between 3 and 59, inclusive.
    //•	Allowed working time for your program: 0.25 seconds.
    // •	Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] diamond = new char[n, n];
        //матрица n x n от '-'
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                diamond[i, j] = '-';
            }
        }
        //попълване на звездичките, започвайки от горе в средата (0; n/2) и слизайки надолу и наляво до (n/2; 0)
        int row = 0;
        int col = n / 2;
        while (row <= n/2 && col >= 0)
        {
            diamond[row, col] = '*';
            row++;
            col--;
        }
        
        //попълване на звездичките, започвайки от горе в средата (0; n/2) и слизайки надолу и надясно до (n/2; 0)
        row = 0;
        col = n / 2;
        while (row <= n / 2 && col <= n-1)
        {
            diamond[row, col] = '*';
            row++;
            col++;
        }
        //попълване на звездичките, започвайки от долу в средата (n-1; n/2) и качвайки се нагоре и наляво до (n/2; 0)
        row = n - 1;
        col = n / 2;
        while (row >= n / 2 && col >= 0)
        {
            diamond[row, col] = '*';
            row--;
            col--;
        }
        //попълване на звездичките, започвайки от долу в средата (n-1; n/2) и качвайки се нагоре и надясно до (n/2; n-1)
        row = n - 1;
        col = n / 2;
        while (row >= n / 2 && col <= n-1)
        {
            diamond[row, col] = '*';
            row--;
            col++;
        }
        //display the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(diamond[i, j]);
            }
            Console.WriteLine();
        }
    }
}
