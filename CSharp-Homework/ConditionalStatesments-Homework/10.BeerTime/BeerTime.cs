using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("enters a time in format “hh:mm tt”:");
        DateTime t = DateTime.Parse(Console.ReadLine());
        TimeSpan time = t - t.Date;
        //Console.WriteLine(time);
        TimeSpan start = TimeSpan.Parse("13:00");
        TimeSpan end = TimeSpan.Parse("03:00");
        if ((time >= start) || (time <= end))
        {
            Console.WriteLine("beer time");
        }
        else if ((time < start) || (time > end))
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
