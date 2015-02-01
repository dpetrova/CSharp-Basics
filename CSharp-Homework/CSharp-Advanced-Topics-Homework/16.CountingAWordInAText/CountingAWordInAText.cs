using System;
using System.Linq;
using System.IO;

class CountingAWordInAText
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput())); //increase console input maximum length
        Console.Write("enter a single word:");
        string word = Console.ReadLine();
        string lowerLettersWord = word.ToLower();
        Console.Write("enter a text:");
        string text = Console.ReadLine();
        foreach (var symbol in text)
        {
            if (!Char.IsLetter(symbol))
            {
                text = text.Replace(symbol, ' ');
            }
        }
        string[] wordsInText = text.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = wordsInText.Count(w => w.ToLower() == lowerLettersWord);
        Console.WriteLine(count);
    }
}

