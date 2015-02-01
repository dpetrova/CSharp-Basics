using System;

class Diamonds
{
    //Write a program that prints a diamond of given size n.
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
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine(new string('-', n / 2 - i) + '*' + new string('-', 2 * i - 1) + '*' + new string('-', n / 2 - i));
        }
        for (int i = 1; i < n/2; i++)
        {
            Console.WriteLine(new string('-', i) + '*' + new string('-', n - (i + 1) * 2) + '*' + new string('-', i));
        }
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
    }
}
