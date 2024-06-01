using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cats", "Cats", 5);
        video1.CreateComment("I love cats", "Luciana");
        video1.CreateComment("I love cats", "Luciana");
        video1.CreateComment("I love cats", "Luciana");

        Video video2 = new Video("Dogs", "Dogs", 10);
        video2.CreateComment("I love dogs", "Luciana");
        video2.CreateComment("I love dogs", "Luciana");
        video2.CreateComment("I love dogs", "Luciana");

        Video video3 = new Video("Birds", "Birds", 15);
        video3.CreateComment("I love birds", "Luciana");
        video3.CreateComment("I love birds", "Luciana");
        video3.CreateComment("I love birds", "Luciana");

        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo(); 
    }
}