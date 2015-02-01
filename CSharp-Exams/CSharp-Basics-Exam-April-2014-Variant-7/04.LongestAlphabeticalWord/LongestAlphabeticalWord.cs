using System;
using System.Collections.Generic;

class LongestAlphabeticalWord
{
    //Nakov enjoys playing with words. Recently he invented the following puzzle game. He starts by given word w (e.g. 
    //"softwareuniversity") and he fills a square block of size n*n (e.g. n=7) with this word as many times as it fits, from left
    //to right and from up to down (see the example on the right). It is also called Nakov's square block of word w and size n.
    //Nakov defines an alphabetical word as a sequence of letters, where each letter is alphabetically after its previous letter
    //in the word. For example, "abc", "fo" and "aeou" are alphabetical words, but "zabc", "srevi" and "ntaeou" are not.
    //Now Nakov wants to find the longest alphabetical word in the obtained square block. The word can start anywhere in the
    //square block and can run in left, right, up or down direction and cannot go outside of the square block. In our example,
    //if we start from row 3 and column 2 in our 7 x 7 square block, we find the following alphabetical words: "aw" 
    //(left direction), "ar" (right direction), "at" (up direction) and "aeou" (down direction).
    //Write a program that reads a word w and a number n and finds the longest alphabetical word in Nakov's square block of 
    //word w and size n. If more than one longest alphabetical words exist in the block, find the smallest of them in the 
    //standard lexicographical order.

    static void Main()
    {
        string inputWord = Console.ReadLine();
        byte n = byte.Parse(Console.ReadLine());
        //Print the matrix of letters
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {
        //        Console.Write(GetLetterAtPosition(inputWord, n, row, col));
        //    }
        //    Console.WriteLine();
        //}

        // Find the longest alphabetical word in the matrix of letters
        string longestAlphaWord = "";
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                string strLeft = FindAlphabeticalWord(inputWord, n, row, col, -1, 0);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strLeft);
                string strRight = FindAlphabeticalWord(inputWord, n, row, col, +1, 0);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strRight);
                string strUp = FindAlphabeticalWord(inputWord, n, row, col, 0, -1);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strUp);
                string strDown = FindAlphabeticalWord(inputWord, n, row, col, 0, +1);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strDown);
            }
        }
        Console.WriteLine(longestAlphaWord);
    }


    private static char GetLetterAtPosition(string inputWord, int n, int row, int col)
    {
        char ch = inputWord[(row * n + col) % inputWord.Length];
        return ch;
    }


    private static string FindAlphabeticalWord(
        string inputWord, int n, int row, int col, int directionX, int directionY)
    {
        List<char> letters = new List<char>();
        char previousLetter = GetLetterAtPosition(inputWord, n, row, col);
        letters.Add(previousLetter);
        while (true)
        {
            col = col + directionX;
            row = row + directionY;
            if (row < 0 || row >= n || col < 0 || col >= n)
            {
                // We are of range --> stop appending letters
                break;
            }
            char nextLetter = GetLetterAtPosition(inputWord, n, row, col);
            if (nextLetter <= previousLetter)
            {
                // Non alphabetical order --> stop appending letters
                break;
            }
            letters.Add(nextLetter);
            previousLetter = nextLetter;
        }
        string alphaWord = new string(letters.ToArray());
        return alphaWord;
    }


    private static string GetBetterWord(string firstWord, string secondWord)
    {
        if ((firstWord.Length > secondWord.Length) ||
            ((firstWord.Length == secondWord.Length &&
             firstWord.CompareTo(secondWord) < 0)))
        {
            return firstWord;
        }
        return secondWord;
    }
    
}
