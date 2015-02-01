using System;

class Nums
{
    //Write a program that reads numbers n and m. The program should go through each number in the range [n..m] and print 
    //its square root (√) if the number is even or number^2 if it's odd.
    //Example: n is 5 and m is 11, so all the numbers in the range are 5, 6, 7, 8, 9, 10 and 11. 5 is odd, so we print
    //52 = 25.000. 6 is even so we print √6 = 2.449, 7 is odd – 72 = 49.000, etc.
    //Input
    //The input data is read from the console. 
    //•	The input consists of 2 lines:
    //o	On the first line you will receive the number n
    //o	On the second line you will receive the number m 
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console – each number's calculation should be printed on a separate line. 
    //The resulting number should be rounded to 3 digits after the decimal separator.
    //Constraints
    //•	The numbers n and m will be integer numbers in the range [0..100]. 
    //•	Time limit: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte m = byte.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0)
            {
                double squareRoot = Math.Sqrt(i);
                Console.WriteLine("{0:0.000}", squareRoot);
            }
            else
            {
                double powerNumber = i * i;
                Console.WriteLine("{0:0.000}", powerNumber);
            }
        }
    }
}
