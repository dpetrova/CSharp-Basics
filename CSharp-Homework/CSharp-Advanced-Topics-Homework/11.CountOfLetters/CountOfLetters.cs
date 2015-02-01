using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        Console.Write("enter a list of letters:");
        List<string> input = new List<string>(Console.ReadLine().Split());
        List<char> letters = new List<char>();
        for (int i = 0; i < input.Count; i++)
        {
            letters.Add(char.Parse(input[i]));
        }

        letters.Sort(); //alphabetical order
        int index = 0;
        List<int> counts = new List<int>();
        //fill the List of counters
        counts.Add(1);
        for (int i = 0; i < letters.Count - 1; i++)
        {
            if (letters[i] != letters[i + 1])
            {
                counts.Add(1);
                index++;
            }
            else
            {
                counts[index]++;
            }
        }

        letters = letters.Distinct().ToList(); //remove repeating letters
        
        //create a dictionary with keys = letters and values = counters 
        Dictionary<char, int> dict = letters.ToDictionary(x => x, x => counts[letters.IndexOf(x)]);
        
        //print the dictionary
        foreach (var entry in dict)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
        }       
    }
}

