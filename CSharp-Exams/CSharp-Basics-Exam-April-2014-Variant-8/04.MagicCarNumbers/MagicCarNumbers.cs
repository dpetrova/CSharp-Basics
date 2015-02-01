using System;

class MagicCarNumbers
{
    //Cars in Sofia have registration numbers in format "CAabcdXY" where a, b, c and d are digits from 0 to 9 and X and Y are
    //letters from the following subset of the Latin alphabet: 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T' and 'X'. 
    //Examples of car numbers from Sofia are "CA8517TX", "CA2277PC", "CA0710XC", "CA1111AC", while "CC7512FJ" in not valid
    //car number from Sofia. Local people are keen to choose special numbers for their cars, know as magic car numbers. 
    //They calculate the weight of a car number as follows: they sum its digits and letters, assuming that letters have 
    //the following values: 'A' -> 10, 'B' -> 20, 'C' -> 30, 'E' -> 50, 'H' -> 80, 'K' -> 110, 'M' -> 130, 'P' -> 160,
    //'T' -> 200, 'X' -> 240. For example the weight("CA6511BM") = 30 + 10 + 6 + 5 + 1 + 1 + 20 + 130 = 203. A magic car 
    //number is a car number that has a special magic weight (e.g. 256 or 512 for developers) and its number is in some of
    //the formats "CAaaaaXY", "CAabbbXY", "CAaaabXY", "CAaabbXY", "CAababXY" and "CAabbaXY", where a and b are two different
    //digits and X and Y are letters from the Latin alphabet subset { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' }.
    //Your task is to write a program that calculates how many cars can be registered in Sofia for given magic weight.
    //Input
    //The input data should be read from the console. It will consist of a single value: the magic weight.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It is a single value: the number of cars matching given magic value.
    //Constraints
    //•	All input numbers will be integers in the range [1…1000].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    private static int count = 0;

    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        for (int s1 = 0; s1 < letters.Length; s1++)
        {
            for (int s2 = 0; s2 < letters.Length; s2++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    string carNumber1 = "" + 'C' + 'A' + a + a + a + a + letters[s1] + letters[s2];
                    CheckCarNumber(carNumber1, magicWeight);
                    for (int b = 0; b <= 9; b++)
                    {
                        if (a != b)
                        {
                            string carNumber2 = "" + 'C' + 'A' + a + b + b + b + letters[s1] + letters[s2];
                            CheckCarNumber(carNumber2, magicWeight);
                            string carNumber3 = "" + 'C' + 'A' + a + a + a + b + letters[s1] + letters[s2];
                            CheckCarNumber(carNumber3, magicWeight);
                            string carNumber4 = "" + 'C' + 'A' + a + a + b + b + letters[s1] + letters[s2];
                            CheckCarNumber(carNumber4, magicWeight);
                            string carNumber5 = "" + 'C' + 'A' + a + b + a + b + letters[s1] + letters[s2];
                            CheckCarNumber(carNumber5, magicWeight);
                            string carNumber6 = "" + 'C' + 'A' + a + b + b + a + letters[s1] + letters[s2];
                            CheckCarNumber(carNumber6, magicWeight);
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }


    private static void CheckCarNumber(string carNumber, int magicWeight)
    {
        int weight = 0;
        int totalWeight = 0;
        foreach (var symbol in carNumber)
        {
            switch (symbol)
            {
                case '0': weight = 0; break;
                case '1': weight = 1; break;
                case '2': weight = 2; break;
                case '3': weight = 3; break;
                case '4': weight = 4; break;
                case '5': weight = 5; break;
                case '6': weight = 6; break;
                case '7': weight = 7; break;
                case '8': weight = 8; break;
                case '9': weight = 9; break;
                case 'A': weight = 10; break;
                case 'B': weight = 20; break;
                case 'C': weight = 30; break;
                case 'E': weight = 50; break;
                case 'H': weight = 80; break;
                case 'K': weight = 110; break;
                case 'M': weight = 130; break;
                case 'P': weight = 160; break;
                case 'T': weight = 200; break;
                case 'X': weight = 240; break;
            }
            totalWeight += weight;
        }
        if (totalWeight == magicWeight)
        {
            count++;
            //Console.WriteLine(carNumber);
        }
    }
}
