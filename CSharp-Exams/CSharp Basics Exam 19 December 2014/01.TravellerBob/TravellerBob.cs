using System;

class TravellerBob
{
    static void Main()
    {
        string year = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        int contractTravels = 3 * 4 * contractMonths;
        int familyTravels = 2 * 2 * familyMonths;
        double normalTravels = (12 - (contractMonths + familyMonths)) * 3.0 / 5.0 * 3 * 4;
        double allTravels = contractTravels + familyTravels + normalTravels;
        if (year == "leap")
        {
            allTravels = allTravels * 1.05;
        }
        Console.WriteLine((int)allTravels);
    }
}
