using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;

        Journal journal = new Journal();
        
        PromptGenerator prompt = new PromptGenerator();

        //10. Shows creativity and exceeds core requirements
        //generate random message of welcome
        PromptGenerator welcome = new PromptGenerator();

        prompt._prompts.Add("What moments today brought me the most joy or fulfillment?");
        prompt._prompts.Add("Did I act in alignment with my values and goals today?");
        prompt._prompts.Add("What challenges did I face, and how did I respond to them?");
        prompt._prompts.Add("Did I learn something new today, and if so, what was it?");
        prompt._prompts.Add("How did my interactions with others impact them and me?");
        prompt._prompts.Add("Did I take care of my physical and mental well-being today?");
        prompt._prompts.Add("What am I grateful for today, big or small?");
        prompt._prompts.Add("What could I have done differently or better today?");
        prompt._prompts.Add("What progress did I make toward my long-term aspirations today?");
        prompt._prompts.Add("How can I carry the lessons and experiences of today into tomorrow for continued growth?");

        welcome._prompts.Add("Welcome to your personal journal! Here's to a journey of self-discovery and reflection.");
        welcome._prompts.Add("Hello and welcome to your journal! May each entry bring clarity and insight.");
        welcome._prompts.Add("Welcome to your own private journal. Let your thoughts wander and your creativity soar.");
        welcome._prompts.Add("Greetings and welcome to your journal! Write your story, one page at a time.");
        welcome._prompts.Add("Welcome to your special place for thoughts and dreams. Enjoy every moment of journaling!");

        Console.WriteLine(welcome.AutoPromptGenerator());

        while (choice != 5)
        {
            choice = Program.DisplayMenu();

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry._prompt = prompt.AutoPromptGenerator();
                Console.WriteLine(entry._prompt);
                Console.Write("> ");
                entry._response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                journal.AddEntry(entry);
                
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                journal.Load();
            }
            else if (choice == 4)
            {
                journal.Save();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
        
    }

    static int DisplayMenu()
    {
        
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What is your choice? ");

        return int.Parse(Console.ReadLine());
    }

    
}