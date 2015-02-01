using System;
using System.Linq;
using System.IO;

class LongestWordInText
{
    //put the text in text.txt: \CSharp-Advanced-Topics-Homework\14.LongestWordInText\bin\Debug\text.txt and enter the full path below, e.g. C:\Temp\...\text.txt
    
    static void Main()
    {
        StreamReader textReader = new StreamReader(@"C:\Users\urukhai\Documents\Visual Studio 2010\Projects\CSharp-Advanced-Topics-Homework\14.LongestWordInText\bin\Debug\text.txt"); //file is in project/bin/Debug or use its full path, e.g. C:\Temp\...\text.txt)
        string text = textReader.ReadToEnd();
        foreach (var symbol in text)
        {
            if (Char.IsPunctuation(symbol))
            {
                text = text.Replace(symbol, ' ');
            }
        }
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = words[0];
        int maxCount = words[0].Length;
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > maxCount)
            {
                maxCount = words[i].Length;
                longestWord = words[i];
            }
        }
        Console.WriteLine(longestWord);
    }
}
