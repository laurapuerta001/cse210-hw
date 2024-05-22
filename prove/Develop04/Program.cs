using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        string name = "";
        string description = "";
        int time = 0;
        int count = 0;

        List<string> reflectingPrompts = new List<string>();

        reflectingPrompts.Add("Think of a time when you stood up for someone else.");
        reflectingPrompts.Add("Think of a time when you did something really difficult.");
        reflectingPrompts.Add("Think of a time when you helped someone in need.");
        reflectingPrompts.Add("Think of a time when you did something truly selfless.");


        List<string> listingPrompts = new List<string>();

        listingPrompts.Add("Who are people that you appreciate?");
        listingPrompts.Add("What are personal strengths of yours?");
        listingPrompts.Add("Who are people that you have helped this week?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");

        List<string> questions = new List<string>();

        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");

        while (choice != 4)
        {
            choice = DisplayMenu();

            if (choice == 1)
            {
                Console.Clear();
                name = "Breathing Activity";
                description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ";

                BreathingActivity breathing = new BreathingActivity(name, description, time);

                breathing.Run();
               
                
                
            }
            else if (choice == 2)
            {
                Console.Clear();
                name = "Reflecting Activity";
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity reflection = new ReflectingActivity(name, description, time, reflectingPrompts, questions);
                
                reflection.Run();
                
            }
            else if (choice == 3)
            {
                Console.Clear();
                name = "Listing Activity";
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                ListingActivity listing = new ListingActivity(name, description, time, listingPrompts, count);

                listing.Run();
                
            }
            else
            {

            }
        }
        

    }

    static int DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");

        Console.WriteLine("1. Start breating activity");

        Console.WriteLine("2. Start reflection activity");

        Console.WriteLine("3. Start listing activity");

        Console.WriteLine("4. Quit");

        Console.Write("What is your choice? ");

        return int.Parse(Console.ReadLine());
    }
}