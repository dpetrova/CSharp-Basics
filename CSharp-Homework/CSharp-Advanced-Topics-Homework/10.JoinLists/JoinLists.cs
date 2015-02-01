using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.Write("enter list of integers:");
        List<string> str1 = new List<string>(Console.ReadLine().Split());
        List<int> numbers1 = new List<int>();
        for (int i = 0; i < str1.Count; i++)
        {
            numbers1.Add(int.Parse(str1[i]));
        }
        Console.Write("enter another list of integers:");
        List<string> str2 = new List<string>(Console.ReadLine().Split());
        List<int> numbers2 = new List<int>();
        for (int i = 0; i < str2.Count; i++)
        {
            numbers2.Add(int.Parse(str2[i]));
        }

        numbers1 = numbers1.Union(numbers2).Distinct().ToList();
        numbers1 = numbers1.OrderBy(x => x).ToList();

        Console.WriteLine(String.Join(" ", numbers1));
    }
}
