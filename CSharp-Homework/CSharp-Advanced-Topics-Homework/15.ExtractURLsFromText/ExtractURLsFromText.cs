using System;
using System.IO;
using System.Collections.Generic;

class ExtractURLsFromText
{
    //put a text in: \CSharp-Advanced-Topics-Homework\13.AverageLoadTimeCalculator\bin\Debug\text.txt

    static void Main()
    {
        StreamReader textReader = new StreamReader("text.txt");
        string text = textReader.ReadToEnd();
        //Console.Write("enter a text:");
        //string text = Console.ReadLine();
        string[] words = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> URLs = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith("http://") || words[i].StartsWith("www."))
            {
                URLs.Add(words[i]);
            }
        }
        foreach (var entry in URLs)
        {
            Console.WriteLine(entry);
        }
    }
}

