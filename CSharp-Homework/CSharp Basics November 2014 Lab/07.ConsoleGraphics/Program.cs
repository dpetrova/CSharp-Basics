using System;

class Program
{
    //Bridge
    //Modify your program to print a bridge. Upload your solution to the Judge System.
    //Tips: Use a for loop. Study the bridge dimensions from the output.
    //Example n=5
    //      **********
    //      **********
    //      ***    ***
    //      ***    ***
    //      ***    ***
    //      ***    ***
    //      ~~~~~~~~~~
    //      ~~~~~~~~~~
   
    //Constraints
    //•	n will always be an odd number in the range [3…49].

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string line = new string('*', 2 * n);
        string bridge = new string('*', n / 2 + 1) + new string(' ', n - 1) + new string('*', n / 2 + 1);
        string river = new string('~', 2 * n);
        Console.WriteLine(line);
        Console.WriteLine(line);
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(bridge);
        }
        Console.WriteLine(river);
        Console.WriteLine(river);
    }
}
