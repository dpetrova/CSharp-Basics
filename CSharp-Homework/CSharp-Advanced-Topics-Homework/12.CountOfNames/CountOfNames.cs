using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        Console.Write("enter a list of names:");
        List<string> names = new List<string>(Console.ReadLine().Split());
        names.Sort(); //increasing order
        int index = 0;
        List<int> counts = new List<int>();
        //fill the List of counters
        counts.Add(1);
        for (int i = 0; i < names.Count - 1; i++)
        {
            if (names[i] != names[i + 1])
            {
                counts.Add(1);
                index++;
            }
            else
            {
                counts[index]++;
            }
        }

        names = names.Distinct().ToList(); //remove repeating names

        //create a dictionary with keys = names and values = counters 
        Dictionary<string, int> dict = names.ToDictionary(x => x, x => counts[names.IndexOf(x)]);

        //print the dictionary
        foreach (var entry in dict)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
        }       
    }
}
