﻿using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //DateTimeModification();
        //DateTimeFormatting();
        //TimeMeasurement();
        DateTimeHelpers();
    }

    private static void DateTimeHelpers()
    {
        int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);
        bool is2021LeapYear = DateTime.IsLeapYear(2021);

        Console.WriteLine("daysInFeb2021: " + daysInFeb2021);
        Console.WriteLine("is2021LeapYear: " + is2021LeapYear);
    }

    private static void TimeMeasurement()
    {
        Console.WriteLine("What is 2+2?");
        Console.WriteLine("A) 4");
        Console.WriteLine("B) 6");
        Console.WriteLine("C) 8");

        DateTime start = DateTime.Now;

        Stopwatch stopwatch = Stopwatch.StartNew();

        string userAnswer = Console.ReadLine();

        stopwatch.Stop();


        DateTime end = DateTime.Now;

        TimeSpan responseTime = end - start;

        Console.WriteLine("Response took you : " + responseTime.TotalSeconds + " seconds");
        Console.WriteLine("Response took you : " + stopwatch.Elapsed.TotalSeconds + " seconds");
    }

    private static void DateTimeFormatting()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToString("g"));
        Console.WriteLine(now.ToString("G"));
        Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
    }

    private static void DateTimeModification()
    {
        DateTime now = DateTime.Now;
        DateTime openDate = new DateTime(1992, 6, 17);

        var result = now - openDate;

        Console.WriteLine(result.Days);


        DateTime expiresAt = now.AddDays(7);
        DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

        Console.WriteLine(expiresAt);
        Console.WriteLine(expiresAt2);


        bool expiresAtTheSameDay = expiresAt.Date == expiresAt2.Date;
        Console.WriteLine(expiresAtTheSameDay);
    }
}