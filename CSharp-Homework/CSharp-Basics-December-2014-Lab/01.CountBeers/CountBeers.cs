using System;

class CountBeers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int allBeers = 0;
        while (input != "End")
        {
            string[] countMeasure = input.Split();
            if (countMeasure[1] == "beers")
            {
                allBeers += int.Parse(countMeasure[0]);
            }
            else
            {
                allBeers += 20 * (int.Parse(countMeasure[0]));
            }
            input = Console.ReadLine();
        }
        int stacks = allBeers / 20;
        int beers = allBeers % 20;
        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
        
    }
}
