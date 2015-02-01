using System;
using System.Collections.Generic;

class PokerStraight
{
    static void Main()
    {
        int target = int.Parse(Console.ReadLine());
        int resultCounter = 0;
        char[] suits = new char[] { 'C', 'D', 'H', 'S' };
        int[] suitsValues = new int[] { 1, 2, 3, 4, };

        for (int firstCard = 1; firstCard <= 14; firstCard++)
        {
            for (int firstCardSuit = 0; firstCardSuit < suitsValues.Length; firstCardSuit++)
            {
                int firstWeight = (10 * firstCard) + suitsValues[firstCardSuit];

                for (int secondCard = 1; secondCard <= 14; secondCard++)
                {
                    for (int secondCardSuit = 0; secondCardSuit < suitsValues.Length; secondCardSuit++)
                    {
                        int secondWeight = (20 * secondCard) + suitsValues[secondCardSuit];

                        for (int thirdCard = 1; thirdCard <= 14; thirdCard++)
                        {
                            for (int thirdCardSuit = 0; thirdCardSuit < suitsValues.Length; thirdCardSuit++)
                            {
                                int thirdWeight = (30 * thirdCard) + suitsValues[thirdCardSuit];

                                for (int fourthCard = 1; fourthCard <= 14; fourthCard++)
                                {
                                    for (int fourthCardSuit = 0; fourthCardSuit < suitsValues.Length; fourthCardSuit++)
                                    {
                                        int fourthWeight = (40 * fourthCard) + suitsValues[fourthCardSuit];

                                        for (int fifthCard = 1; fifthCard <= 14; fifthCard++)
                                        {
                                            for (int fifthCardSuit = 0; fifthCardSuit < suitsValues.Length; fifthCardSuit++)
                                            {
                                                int fifthWeight = (50 * fifthCard) + suitsValues[fifthCardSuit];

                                                if (fifthCard - fourthCard == 1 && fourthCard - thirdCard == 1 && thirdCard - secondCard == 1 && secondCard - firstCard == 1)
                                                {
                                                    if (firstWeight + secondWeight + thirdWeight + fourthWeight + fifthWeight == target)
                                                    {
                                                        resultCounter++;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(resultCounter);
    }
}
