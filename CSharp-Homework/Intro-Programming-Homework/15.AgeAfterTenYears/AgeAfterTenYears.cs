using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birthday (mm/dd/yyyy):");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        TimeSpan age = now.Date - birthDay.Date;
        Console.WriteLine("You are " + (int)age.TotalDays / 365 + " years old");
        Console.WriteLine("After 10 years you will be " + (((int)age.TotalDays / 365) + 10) + " years old");
    }
}