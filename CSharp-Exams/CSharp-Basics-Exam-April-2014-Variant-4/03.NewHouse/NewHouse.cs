using System;

class NewHouse
{
    //Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to the big city and start
    //building houses. But his knowledge of how to do this is limited. Help Joro to design the façade of a beautiful house by 
    //printing it to the console. The house must have a roof and one floor. The roof must contains only the symbols ‘*’ and ‘-’ and
    //the floor must contains the symbols ‘*’ and ‘|’ (see the examples below).
    //Input
    //•	The input data should be read from the console.
    //•	At the only input line you are given an integer number N (always an odd number) showing the height of the house (without the roof).
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output should be printed on the console.
    //•	You should print the house on the console, just like in the examples below. Each row can contain only the following characters: “-” (dash), “*” (asterisk) and “|” (pipe). 
    //Constraints
    //•	The number N will be a positive odd integer number between 3 and 101, inclusive.
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    //Example n=5: --*--
    //             -***-
    //             *****
    //             |***|
    //             |***|
    //             |***|
    //             |***|
    //             |***|
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        //printing roof
        for (int i = 1; i <= N; i +=  2)
        {
            int dashesCount = (N - i) / 2;
            string dashes = new string('-', dashesCount);
            string asterisks = new string('*', i);
            Console.Write(dashes);
            Console.Write(asterisks);
            Console.Write(dashes);
            Console.WriteLine();
        }
        
        //printing floor
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("{0}{1}{0}", "|", new string('*', N - 2));
        }
    }
}
