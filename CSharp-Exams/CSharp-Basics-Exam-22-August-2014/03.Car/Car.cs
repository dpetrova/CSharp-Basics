using System;

class Car
{
    //You will be given an integer N. The width of the car is (3*N). The height of the car is (3*N/2-1).  The roof height and
    //the body height is exactly (N/2).  The car’s wheels height are (N/2-1). 
    //Input
    //•	Input data is read from the console.
    //•	The number N stays alone at the first line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	You must print at the console a car of size N following the formulas above and the examples below.
    //Constraints
    //•	N will be a number between 6 and 36 and will be an even number.
    //•	Time limit: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    //Example: N=6  ......******......
    //              .....*......*.....
    //              ....*........*....
    //              ****..........****
    //              *................*
    //              ******************
    //              ...*..*....*..*...
    //              ...****....****...


    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', N) + new string('*', N) + new string('.', N));
        for (int i = 0; i < N/2 - 1; i++)
        {
            Console.WriteLine(new string('.', N - i - 1) + '*' + new string('.', N + 2 * i) + '*' + new string('.', N - i - 1));
        }
        Console.WriteLine(new string('*', N / 2 + 1) + new string('.', 2 * N - 2) + new string('*', N / 2 + 1));
        for (int i = 0; i < N/2 -2; i++)
        {
            Console.WriteLine('*' + new string ('.', 3*N - 2) + '*');
        }
        Console.WriteLine(new string ('*', 3 * N));
        for (int i = 0; i < N/2 -2; i++)
        {
            Console.WriteLine(new string('.', N / 2) + '*' + new string('.', N / 2 - 1) + '*' + new string('.', N - 2) +
                                                            '*' + new string('.', N / 2 - 1) + '*' + new string('.', N / 2));
        }
        Console.WriteLine(new string('.', N / 2) + new string('*', N / 2 + 1) + new string('.', N - 2) +
                                                                    new string('*', N / 2 + 1) + new string('.', N / 2));
    }
}
