using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>();

        var run1 = new Running("04 Mar 1969", "Running", 15, 1.5);
        activities.Add(run1);
        var ride1 = new Cycling("25 Dec 3333", "Cycling", 120, 16);
        activities.Add(ride1);
        var swim1 = new Swimming("01 Jan 0000AD", "Swimming", 30, 45);
        activities.Add(swim1);

        foreach (Activity a in activities){
            Console.WriteLine(a.GetSummary());
            Console.WriteLine("");
        }
    }
}