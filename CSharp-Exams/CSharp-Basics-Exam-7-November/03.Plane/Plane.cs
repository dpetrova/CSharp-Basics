﻿using System;

class Plane
{
    //You will be given an integer N. The width of the plane is (3*N). The height of the plane is ((N * 3) – (N / 2)) 
    //and the width is (N * 3). Check the examples below to understand your task better.
    //Input
    //Input data is read from the console.
    //•	The number N stays alone at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You must print at the console a picture of size N following the formulas above and the examples below.
    //Constraints
    //•	N will be a number between 5 and 31 and will be an odd number.
    //•	Time limit: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n + (n / 2)));
        int dotsBefore = n + (n / 2) - 1;
        int dotsMiddle = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsMiddle += 2;
            dotsBefore--;
        }

        dotsBefore = n;
        dotsMiddle = n + 2;
        for (int i = 0; i < n / 2; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsMiddle += 4;
        }

        dotsBefore = n - 2;
        dotsMiddle = n;
        int dotsBetween = 1;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', dotsBefore), new string('.', dotsMiddle));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine(
                "*{0}*{2}*{1}*{2}*{0}*",
                new string('.', dotsBefore),
                new string('.', dotsMiddle),
                new string('.', dotsBetween));
            dotsBetween += 2;
        }

        dotsBefore = n - 2;
        dotsBefore++;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsBefore--;
            dotsMiddle += 2;
        }

        Console.WriteLine(new string('*', n * 3));
    }
}
