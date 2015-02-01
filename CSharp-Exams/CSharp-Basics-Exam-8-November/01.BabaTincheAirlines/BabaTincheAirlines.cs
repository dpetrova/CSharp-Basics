using System;

class BabaTincheAirlines
{
    //Every month Baba Tinche travels to the Republic of Tajikistan to meet her boyfriend. But the tickets are so expensive
    //that she decides to establish her own airline instead called Baba Tinche Airlines. There are three travel classes in
    //Baba Tinche Airlines:
    //•	First Class which accommodates 12 passengers. The ticket price is $7000.
    //•	Business Class which accommodates 28 passengers. The ticket price is $3500.
    //•	Economy Class which accommodates 50 passengers. The ticket price is $1000.
    //Please note that some passengers are Frequent Flyers and their tickets are 70% off ($1000 ticket will cost $700).
    //Also some passengers purchase a meal on the flight, which costs 0.5% of the ticket price for the travel class they 
    //are in. Please help Baba Tinche calculate her income and calculate the difference between her income and the maximum
    //possible income (the maximum possible income being all seats taken, no Frequent Flyers and everyone purchasing meals).
    //You will be given the number of passengers for each class, the number of passengers who are Frequent Flyers in that
    //class, and the number of passengers who purchase a meal in that class.
    //Input
    //The input data should be read from the console. It consists of exactly 3 lines:
    //•	The first line holds the number of all passengers in First Class
    //•	The second line holds the number of all passengers in Business Class
    //•	The third line holds the number of all passengers in Economy Class
    //•	The second and third number on all lines will be the number of Frequent Flyers and the number of passengers who 
    //will purchase a meal in the given class.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 2 lines.
    //•	The first line will  hold Baba Tinche’s income cast to an integer
    //•	The second line holding the difference between the maximum possible profit and baba Tinche’s actual profit cast to
    //an integer
    //Constraints
    //•	The first number in the first line will be in the range [0…12]. 
    //•	The first number in the second line will be in the range [0…28]. 
    //•	The first number in the third line will be in the range [0…50]. 
    //•	The second and third numbers on all lines will be less or equal to the first number.
    //•	Allowed memory: 16 MB. Allowed working time: 0.25 seconds.

    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        byte passengersFirstClass = byte.Parse(firstClass[0]);
        byte frequentFlyersFirstClass = byte.Parse(firstClass[1]);
        byte mealsFirstClass = byte.Parse(firstClass[2]);
        string[] businessClass = Console.ReadLine().Split();
        byte passengersBusinessClass = byte.Parse(businessClass[0]);
        byte frequentFlyersBusinessClass = byte.Parse(businessClass[1]);
        byte mealsBusinessClass = byte.Parse(businessClass[2]);
        string[] economyClass = Console.ReadLine().Split();
        byte passengersEconomyClass = byte.Parse(economyClass[0]);
        byte frequentFlyersEconomyClass = byte.Parse(economyClass[1]);
        byte mealsEconomyClass = byte.Parse(economyClass[2]);

        int maxPossibleIncome = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 * (0.005 * 1000));
        int incomeFirstClass = (int)((passengersFirstClass - frequentFlyersFirstClass) * 7000) +
                                        (int)((frequentFlyersFirstClass * 7000) * 0.3) + (int)((mealsFirstClass * 7000) * 0.005);
        int incomeBusinessClass = (int)((passengersBusinessClass - frequentFlyersBusinessClass) * 3500) +
                                     (int)((frequentFlyersBusinessClass * 3500) * 0.3) + (int)((mealsBusinessClass * 3500) * 0.005);
        int incomeEconomyClass = (int)((passengersEconomyClass - frequentFlyersEconomyClass) * 1000) +
                                        (int)((frequentFlyersEconomyClass * 1000) * 0.3) + (int)((mealsEconomyClass * 1000) * 0.005);
        int allIncome = incomeFirstClass + incomeBusinessClass + incomeEconomyClass;
        Console.WriteLine(allIncome);
        Console.WriteLine(maxPossibleIncome - allIncome);
    }
}
