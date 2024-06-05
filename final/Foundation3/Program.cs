using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Intro to C#", "Introduction to C#", "02/02/2025", "10:00 AM", new Address("123 Main St", "Anytown", "CA", "USA"), "John Smith", 100);
        Reception reception = new Reception("Laura & Kaleb Reception", "Come to celebrate the Laura & Kaleb Reception", "08/23/2024", "06:00 PM", new Address("914 E 5th St", "Verona", "MO", "USA"), "reception@confirmation.com", "08/01/2024");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "Picnic with friends", "07/01/2024", "11:00 AM", new Address("876 N 65 E", "Provo", "UT", "USA"), "Sunny");

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details: ");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details: ");
            if (e is OutdoorGathering)
            {
                Console.WriteLine(e.GetStandardDetails() + "\n" +((OutdoorGathering)e).GetWeather());
            }
            else if (e is Reception)
            {
                Console.WriteLine(e.GetStandardDetails() + "\n" + ((Reception)e).GetRSPVInformation());
            }
            else if (e is Lecture)
            {
                Console.WriteLine(e.GetStandardDetails() + "\n" + ((Lecture)e).GetAdditionalDetails());
            }
            Console.WriteLine();

            Console.WriteLine("Short Details: ");
            string type = "";
            if (e is OutdoorGathering)
            {
                type = "Outdoor Gathering";
            }
            else if (e is Reception)
            {
                type = "Reception";
            }
            else if (e is Lecture)
            {
                type = "Lecture";
                
            }
            Console.WriteLine(e.GetShortDescription(type));
            
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }
        
    }
}