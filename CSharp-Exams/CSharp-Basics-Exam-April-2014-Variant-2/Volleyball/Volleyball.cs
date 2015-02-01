using System;

class Volleyball
{
    //Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he is able to play
    //only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, but not every weekend
    //– only when he is not at work and only when he is not going to his hometown. Vladi goes at his hometown h weekends
    //in the year. The other weekends are considered “normal”. Vladi is not at work in 3/4 of the normal weekends. 
    //When Vladi is at his hometown, he always plays volleyball with his old friends once, at Sunday. In addition, 
    //if the year is leap, Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends
    //suitable for volleyball.
    //Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).
    //Input
    //The input data should be read from the console. It consists of three input values, each at separate line:
    //•	The string “leap” for leap year or “normal” for year that is not leap.
    //•	The number p – number of holidays in the year (which are not Saturday or Sunday).
    //•	The number h – number of weekends that Vladi spends in his hometown.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	On the only output line you must print an integer representing how many times Vladi plays volleyball for a year.
    //Constraints
    //•	The numbers p is in range [0...300] and h is in range [0…48].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double playsInHolidays = (double)(p * 2D / 3D); //много е важно да се сложи суфикс "D",
                                          //за да не прави целочислено делене, т.е. да не отрязва числата след запетайката 
        double playsAtNormalWeekends = (double)((48 - h) * 3D / 4D);
        double playsAtHometown = h;
        double allPlays = playsInHolidays + playsAtHometown + playsAtNormalWeekends;
        if (year == "leap")
        {
            allPlays += allPlays * 0.15;
        }
        Console.WriteLine((int)allPlays);
    }
}