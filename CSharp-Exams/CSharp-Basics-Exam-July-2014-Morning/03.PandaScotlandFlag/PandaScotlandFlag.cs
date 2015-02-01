using System;

class PandaScotlandFlag
{
    //Help the little Panda Stoyan to write a program that prints at the console the Scotland's flag of size N, following the
    //examples below.
    //Input
    //The input data should be read from the console. It consists of a single line holding an integer number N – the size of
    //the flag. The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //Print at the console the Scotland's flag (Stoyan's version) like at the examples below.
    //Constraints
    //•	The input number N always will be odd positive integer number [1…501].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    //Examples N = 9    A#######B
    //                  ~C#####D~
    //                  ~~E###F~~
    //                  ~~~G#H~~~
    //                  ----I----
    //                  ~~~J#K~~~
    //                  ~~L###M~~
    //                  ~N#####O~
    //                  P#######Q

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char letter = 'A';
        for (int i = 0; i < N / 2; i++)
        {
            string tilda = new string('~', i);
            string numberSign = new string('#', N - (2 * i) - 2);
            Console.Write(tilda);
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(numberSign);
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(tilda);
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', N / 2) + letter + new string('-', N / 2));
        letter = GetNextLetter(letter);

        for (int i = N / 2 - 1; i >= 0; i--)
        {
            string tilda = new string('~', i);
            string numberSign = new string('#', N - (2 * i) - 2);
            Console.Write(tilda);
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(numberSign);
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(tilda);
            Console.WriteLine();
        }
    }

    private static char GetNextLetter(char letter)
    {
        if (letter >= 'Z')
        {
            letter = 'A';
        }
        else
        {
            letter ++;
        }
        return letter;
    }
}
