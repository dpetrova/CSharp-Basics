using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.Write("enter list of names:");
        List<string> names1 = new List<string>(Console.ReadLine().Split());
        Console.Write("enter another list of names:");
        List<string> names2 = new List<string>(Console.ReadLine().Split());

        names1.RemoveAll(i => names2.Contains(i));

        Console.WriteLine(String.Join(" ", names1));
    }
}

