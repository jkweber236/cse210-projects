using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("08 Dec 2023", 30, 3);
        activities.Add(running);

        Cycling cycling = new Cycling("09 Dec 2023", 20, 8);
        activities.Add(cycling);

        Swimming swimming = new Swimming("10 Dec 2023", 20, 40);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}