using System;

class MelonsAndWatermelons
{
    //Didko likes to eat melons and watermelons almost every day of the week. Some days he eats only melons, some days only
    //watermelons and some days he eats both. Every day of the week he eats different amount of melons and watermelons. 
    //The table shows how many watermelons and melons he eats in each day of the week. 
    //Monday	1 Watermelon
    //Tuesday	2 Melons
    //Wednesday	1 Watermelon and 1 Melon
    //Thursday	2 Watermelons
    //Friday	2 Watermelons and 2 Melons
    //Saturday	1 Watermelon and 2 Melons
    //Sunday	Didko takes a break

    //You will be given a starting day of the week (1-7) when Didko starts eating, and the amount of days he is eating. 
    //Didko wants to know whether he has eaten more melons, more watermelons or equal amount of watermelons and melons for 
    //the given amount of days. He is not good at counting so he needs your help.
    //Input
    //The input data should be read from the console.
    //•	At the first line comes an integer number s, specifying the starting day of the week.
    //•	At the second line comes an integer number d specifying the amount of sequential days Didko is eating melons and 
    //watermelons.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 1 line:
    //•	Print “{0} more watermelons” if the eaten watermelons are more than the melons.
    //•	Print “{0} more melons” if the eaten melons are more than the watermelons.
    //•	Print “Equal amount: {0}” if the eaten melons and watermelons are the same amount.
    //Constraints
    //•	The starting day s will be an integer in the range [1…7].
    //•	The amount of days d will be an integer in the range [0…100 000].
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int startingDay = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int endingDay = startingDay + days - 1;
        int melons = 0;
        int watermelons = 0;
        for (int i = startingDay; i <= endingDay; i++)
        {
            switch (i % 7)
            {
                case 1: watermelons++;
                    break;
                case 2: melons += 2;
                    break;
                case 3: melons++; watermelons++;
                    break;
                case 4: watermelons += 2;
                    break;
                case 5: melons += 2; watermelons += 2;
                    break;
                case 6: melons += 2; watermelons++;
                    break;
                case 7: melons += 0; watermelons += 0;
                    break;
            }
        }
        int difference = Math.Abs(melons - watermelons);
        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", difference);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", difference);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}
