using System;

class Eclipse
{
    //Write a program to print a figure at the console in the form of sunglasses for watching the solar eclipse.
    //Input
    //•	The input data should be read from the console.
    //•	You have an integer number N (always an odd number) specifying the height of sunglasses.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console.
    //You should print the sunglasses on the console. The sunglasses consist of three parts: frames, lenses and a bridge (the connection between the two frames). Each frame's width is double the height N and should be printed using the character '*' (asterisk) without the corners which should be printed with ' ' (space). Print the lenses with the character '/'. Finally, connect the two frames with a bridge that is of size N-1, using the character '-'. Leave the rest of the space between the frames blank.
    //Constraints
    //•	The number N will be a positive odd integer number in range [3…101].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    //Examples: 7
    //  ************        ************
    // *////////////*      *////////////*
    // *////////////*      *////////////*
    // *////////////*------*////////////*
    // *////////////*      *////////////*
    // *////////////*      *////////////*
    //  ************        ************ 
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string frames = new string('*', 2*N - 2);
        string lenses = new string('/', 2*N - 2);
        string bridge = new string('-', N-1);
        for (int i = 0; i < N; i++)
        {
            if (i == 0 || i == N-1)
            {
                Console.WriteLine(" " + frames + " " + bridge.Replace('-', ' ') + " " + frames + " ");
            }
            else if (i == (N-1)/2)
            {
                Console.WriteLine("*" + lenses + "*" + bridge + "*" + lenses + "*");
            }
            else
            {
                Console.WriteLine("*" + lenses + "*" + bridge.Replace('-', ' ') + "*" + lenses + "*");
            }
        }
    }
}
