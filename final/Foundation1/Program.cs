using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Funny Cats", "Cats", 150);
        video1.CreateComment("I can't stop laughing!", "Sophie");
        video1.CreateComment("I love cats", "Leticia");
        video1.CreateComment("This cat is a comedy star!", "Jonas");

        Video video2 = new Video("Cute Dogs", "Dogs", 120);
        video2.CreateComment("I love dogs", "Fernando");
        video2.CreateComment("Anyone else watching this on repeat?", "Luciana");
        video2.CreateComment("This made my day!", "John");
        video2.CreateComment("What a cute video.", "Sueli");

        Video video3 = new Video("Birds at Home", "Birds", 234);
        video3.CreateComment("Does anyone know what species this bird is?", "Milly");
        video3.CreateComment("He looks so happy!", "Beatriz");
        video3.CreateComment("I love how he interacts with people.", "Ben");

        List<Video> videos = new List<Video>();

        //5. Functionality: Object Creation -  Program runs without errors. It correctly creates at least 3 Video objects (including setting their values), and for each Video creates and sets at least 3 Comment objects (including setting their values). The Video objects are stored in a list.
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //6. Functionality: Object Use - Program runs without errors. It iterates through a list of Video objects and for each one displays the title, author, length, and number of comments (using the method) and for each video also displays the comments for that video (include the commenter's name and text).
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}