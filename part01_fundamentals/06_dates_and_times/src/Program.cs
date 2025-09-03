using System;
using System.Runtime.CompilerServices;

namespace DatesAndTimes;

public class Program
{
    static void Main(string[] arg)
    {
        var dateTime = new DateTime(2025, 01, 01);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        Console.WriteLine(tomorrow);

        Console.WriteLine(now.ToString("yyyyy-MM-dd HH:mm"));
    }
}
