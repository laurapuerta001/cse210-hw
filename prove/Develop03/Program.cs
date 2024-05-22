using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator scriptures = new ScriptureGenerator();

        string holeScripture1 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        string book1 = "1 Nephi";
        int chapter1 = 3;
        int startVerse1 = 7;
        int endVerse1 = 7;
        Reference reference1 = new Reference(book1, chapter1, startVerse1, endVerse1);
        Scripture scripture1 = new Scripture(reference1, holeScripture1);

        string holeScripture2 = "But before ye seek for riches, seek ye for the kingdom of God. 19 And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.";
        string book2 = "Jacob";
        int chapter2 = 2;
        int startVerse2 = 18;
        int endVerse2 = 19;
        Reference reference2 = new Reference(book2, chapter2, startVerse2, endVerse2);
        Scripture scripture2 = new Scripture(reference2, holeScripture2);

        string holeScripture3 = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.";
        string book3 = "Ether";
        int chapter3 = 12;
        int startVerse3 = 4;
        int endVerse3 = 4;
        Reference reference3 = new Reference(book3, chapter3, startVerse3, endVerse3);
        Scripture scripture3 = new Scripture(reference3, holeScripture3);

        scriptures.AddScripture(scripture1);
        scriptures.AddScripture(scripture2);
        scriptures.AddScripture(scripture3);
        
        Scripture randomScripture = scriptures.AutoPromptGenerator();

        randomScripture.GetDisplayText();

        string input = "";

        while (input != "quit" || !randomScripture.IsCompletelyHidden()){
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input == "quit" || randomScripture.IsCompletelyHidden()){
             break;
            }

            randomScripture.HideRandomWords();
            Console.Clear();
            randomScripture.GetDisplayText();
        }

        Console.Write("Thank you for playing!");

    }
}