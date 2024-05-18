using System;

class Program
{
    static void Main(string[] args)
    {
        string holeScripture = "Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string book = "1 Nephi";
        int chapter = 1;
        int startVerse = 1;
        int endVerse = 1;
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, holeScripture);
        
        scripture.GetDisplayText();

        string input = "";

        while (input != "quit" || !scripture.IsCompletelyHidden()){

            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input == "quit" || scripture.IsCompletelyHidden()){
             break;
            }

            scripture.HideRandomWords();

            scripture.GetDisplayText();
        }

        Console.Write("teste");

    }
}