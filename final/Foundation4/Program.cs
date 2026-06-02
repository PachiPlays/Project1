using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running R = new Running("July 12th", 50, 4);

        Cycling C = new Cycling("September 30th", 40, 5);

        Swimming S = new Swimming("June 13th", 30, 10);

        List<Activity> activities = new List<Activity>();

        activities.Add(R);
        activities.Add(C);
        activities.Add(S);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}