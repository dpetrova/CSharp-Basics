﻿using System;

class Gambling
{
    //Do you think you can use your newly acquired coding skills to decide whether a game is worth playing? 
    //You’ll be provided with some amount of cash C you may use to bet on a single hand of a card game called Vokan. You will
    //be shown the house’s hand consisting of four cards (drawn from a standard deck of 52 cards). The hand’s strength is 
    //determined solely by the face values of the cards (suits are ignored). Cards with faces 2 to 10 increase the hand’s 
    //strength with their numeric value. J, Q, K and A add 11, 12, 13 and 14 points respectively. Then, the four cards are
    //shuffled back into the deck. At this point you’ll have to decide whether you want to play or not. Continuing the game
    //means you’ll draw four cards from the deck, one at a time, shuffling back each card before drawing the next; you will
    //then calculate your cards’ combined strength and compare it to the house’s result. 
    //You’ll need to figure out the ratio between the number of winning hands (hands that are stronger than the house’s) and
    //the total number of all possible hands in order to find the probability of you beating the house. If the probability 
    //is < 50% you should quit, otherwise the game is worth the risk. 
    //Assume you bet your entire cash deposit C and the bank matches your bet 1:1; thus the pot’s value will be 2*C. Your
    //expected winnings are calculated as (% probability of winning) * (pot amount). 
    //The output should consist of two lines. On the first line, print your decision - “FOLD” if the game isn’t worth the
    //risk, or “DRAW” otherwise. On the second line, print your expected winnings rounded to two digits after the decimal
    //point (you should use “.” as the decimal separator).
    //Input
    //The input data should be read from the console.
    //•	At the first line you’ll be given some amount of cash C.
    //•	At the second line you’ll be given the house’s hand as a sequence of four cards (faces only), each separated by a single whitespace.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 2 lines:
    //•	The first line should hold a string – one of the two: “FOLD” or “DRAW”.
    //•	The second line should hold your expected winnings of the game, rounded to two decimal points.
    //Constraints
    //•	The number C will be in the range [1.00 … 1 000 000.00].
    //•	The house’s hand will have exactly four cards (faces only) taken from a standard 52-card deck. 
    //•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] houseHand = Console.ReadLine().Split();
        int houseStrength = 0;
        for (int i = 0; i < houseHand.Length; i++)
        {
            switch (houseHand[i])
            {
                case "J": houseStrength += 11; break;
                case "Q": houseStrength += 12; break;
                case "K": houseStrength += 13; break;
                case "A": houseStrength += 14; break;
                default: houseStrength += int.Parse(houseHand[i]); break;
            }
        }
        decimal winningHands = 0;
        decimal totalHands = 0;
        int currentHandStrength = 0;
        for (int c1 = 2; c1 <= 14; c1++)
        {
            for (int c2 = 2; c2 <= 14; c2++)
            {
                for (int c3 = 2; c3 <= 14; c3++)
                {
                    for (int c4 = 2; c4 <= 14; c4++)
                    {
                        currentHandStrength = c1 + c2 + c3 + c4;
                        totalHands++;
                        if (currentHandStrength > houseStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        decimal pot = cash * 2;
        decimal probabilityOfWinning = (winningHands / totalHands) * 100;
        decimal expectedWinnings = (probabilityOfWinning / 100) * pot;
        if (probabilityOfWinning < 50)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:0.00}", expectedWinnings);
    }
}
