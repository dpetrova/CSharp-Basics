using System;

class WineGlass
{
    //Input
    //The input data should be read from the console.
    //•	You have an integer number N (always even number) specifying the height of the wine glass.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. You should print the wine glass on the console following the examples below.
    //•	The glass has exactly N rows, each of which contains exactly N symbols. 
    //•	The first row should contain the backslash (“\”) symbol, a total of (N-2) asterisks (“*”) and the slash (“/”) symbol.
    //•	The second row should contain exactly one dot (”.”) before the backslash, one after the slash and two less
    //(compared to the row above) asterisks between the slash and backslash.
    //•	The third row should contain one more dot at each side and two less asterisks and so on, until the (N /2) row,
    //where there should be no asterisks between the slashes.
    //•	On the next (N/2)-2 rows, if N >= 12 or (N/2)-1 rows, if N < 12, you should print the stem that should look like
    //the following: a count of (N/2)-1 dots (“.”), followed by two vertical lines (“|”) and (N/2)-1 dots after the lines.
    //The remaining one or two rows (up to a total count of N) should be filled with exactly N dashes (“-”) on each row.
    //Constraints
    //•	The number N will be an even integer between 4 and 60, inclusive.
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.
    // Example N = 8:   \******/
    //                  .\****/.
    //                  ..\**/..
    //                  ...\/...
    //                  ...||...
    //                  ...||...
    //                  ...||...
    //                  --------


    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = N - 2; i >= 0; i -= 2)
        {
            int dotCount = (N - i - 2) / 2;
            string dots = new string('.', dotCount);
            string asterisks = new string('*', i);
            Console.Write(dots + "\\" + asterisks + "/" + dots);
            Console.WriteLine();
        }
        if (N >= 12)
        {
            for (int i = 0; i < (N / 2) - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (N - 2) / 2), "||");
            }
            Console.WriteLine(new string('-', N));
            Console.WriteLine(new string('-', N));
        }
        else
        {
            for (int i = 0; i < (N / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (N - 2) / 2), "||");
            }
            Console.WriteLine(new string('-', N));
        }
    }
}
