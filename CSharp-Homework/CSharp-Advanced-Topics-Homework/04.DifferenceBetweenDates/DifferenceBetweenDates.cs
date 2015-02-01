using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("enter a date in format dd.MM.yyyy:");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        Console.Write("enter another date in format dd.MM.yyyy:");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        TimeSpan days = date2 - date1;
        Console.WriteLine(days.Days);
    }
}

