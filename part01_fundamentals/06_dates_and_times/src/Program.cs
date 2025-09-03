using System;
using System.Runtime.CompilerServices;

namespace DatesAndTimes;

public class Program
{
    static void Main(string[] arg)
    {
        // dateTime
        var dateTime = new DateTime(2025, 01, 01);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        var yesterday = now.AddDays(-1);
        Console.WriteLine(tomorrow);
        Console.WriteLine(yesterday);

        Console.WriteLine(now.ToString("yyyyy-MM-dd HH:mm:ss"));

        // timeSpan
        var timeSpan = new TimeSpan(1, 2, 3);
        Console.WriteLine(timeSpan);

        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);
        Console.WriteLine(timeSpan2);

        // properties
        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        // add
        Console.WriteLine("Add Minutes: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        // subtract
        Console.WriteLine("Subtract Minutes: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));
        // toString
        Console.WriteLine("ToString: " + timeSpan.ToString());
        // prase
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:02"));
    }
}
