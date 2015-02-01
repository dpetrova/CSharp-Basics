﻿using System;

class ExamSchedule
{
    //At SoftUni we have a new trainee Stamat, who is assigned to make schedules for the entrance exams. Since today is his
    //first day at work he is a little bit nervous and he is not working very fast. Unfortunately, it seems that he will not have 
    //enough time to make the schedule for the next exam and there is no one else to do the job … except you of course. 
    //You will be given exam starting time in the standard 12-hour clock (hours, minutes and part of the day) and exam duration 
    //(hours and minutes). Your job is to write a program that calculates at what time the exam ends.
    //* Note that the standard 12-hours clock uses the following arrangements of the hours of the day: 12AM (midnight),
    //1AM, 2AM, 3AM, 4AM, 5AM, 6AM, 7AM, 8AM, 9AM, 10AM, 11AM, 12PM (noon), 
    //1PM, 2PM, 3PM, 4PM, 5PM, 6PM, 7PM, 8PM, 9PM, 10PM, 11PM, 12AM, 1AM, … (learn more at http://en.wikipedia.org/wiki/12-hour_clock).
    //Input
    //The input data should be read from the console. The input data consists of exactly 5 lines:
    //•	The first three lines are holding the exam start time: hour, minutes and part of the day (AM or PM).
    //•	The last two lines are holding two integer number: the exam duration hours and minutes.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //You have to print the time the exam ends in format HH:MM:PartOfDay.
    //Constraints
    //•	The starting hour will be an integer number in the range [1…12] inclusive.
    //•	The starting minutes will an integer number in the range [0…59] inclusive.
    //•	The part of the day will consist of exactly two capital letters: AM or PM.
    //•	The duration hours will be an integer number between [0…23] inclusive.
    //•	The duration minutes will be an integer number between [0…59] inclusive.
    //•	Allowed work time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        byte hours = byte.Parse(Console.ReadLine());
        byte minutes = byte.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine();
        byte examDurationHours = byte.Parse(Console.ReadLine());
        byte examDurationMinutes = byte.Parse(Console.ReadLine());
        DateTime start = new DateTime(2014, 11, 13, hours, minutes, 0);
        if (partOfTheDay == "PM")
        {
            start = start.AddHours(12);
        }
        DateTime end = start.AddHours(examDurationHours).AddMinutes(examDurationMinutes);
        //TimeSpan duration = new TimeSpan(examDurationHours, examDurationMinutes, 0);
        //DateTime end = start.Add(duration);
        //string displayTime = end.ToString("hh:mm:tt");
        //Console.WriteLine(displayTime);
        Console.WriteLine("{0:hh:mm:tt}", end);
    }
}
