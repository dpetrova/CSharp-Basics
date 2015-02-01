using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        string[] cardFace = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
        char spade = '\u2660';
        char heart = '\u2665';
        char diamond = '\u2666';
        char club = '\u2663';
        char[] cardSuits = { spade, heart, diamond, club };
        for (int i = 0; i < cardFace.Length; i++)
        {
            for (int j = 0; j < cardSuits.Length; j++)
            {
                Console.Write(cardFace[i] + cardSuits[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
