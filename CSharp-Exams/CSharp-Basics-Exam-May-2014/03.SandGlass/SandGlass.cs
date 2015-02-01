using System;

class SandGlass
{
    //Input
    //•	The input data should be read from the console.
    //•	You have an integer number N (always odd number) showing the height of the sand clock.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output should be printed on the console.
    //•	You should print the hourglass on the console. Each row can contain only the following characters: “.” (dot) and “*” (asterisk). As shown in the example: the middle row must contain only one ‘*’ and all other symbols must be “.”. Every next row (up or down from the middle one) must contain the same number of ‘*’ as the previous one plus two. You should only use “.” to fill-in the rows, where necessary.
    //Constraints
    //•	The number N will be a positive integer number between 3 and 101, inclusive.
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    //Example N = 5:    *****
//                      .***.
//                      ..*..
//                      .***.
//                      *****

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = N; i > 0; i-=2)
        {
            int dotCount = (N - i) / 2;
            string dots = new string('.', dotCount);
            string asterisks = new string('*', i);
            Console.Write(dots + asterisks + dots);
            Console.WriteLine();
        }
        for (int i = 3; i <= N; i+=2)
        {
            int dotCount = (N - i) / 2;
            string dots = new string('.', dotCount);
            string asterisks = new string('*', i);
            Console.Write(dots + asterisks + dots);
            Console.WriteLine();
        }
    }
}
