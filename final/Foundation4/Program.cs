using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, "11/10/2022", 5);
        Cycling cycling = new Cycling(30, "07/03/2023", 5);
        Swimming swimming = new Swimming(30, "10/05/2023", 5);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            string type = "";
            if (activity is Cycling)
            {
                type = "Cycling";
            }
            else if (activity is Running)
            {
                type = "Running";
            }
            else if (activity is Swimming)
            {
                type = "Swimming";
            }
            Console.WriteLine($"{type}: {activity.GetSummary()}");
        }
    }
}