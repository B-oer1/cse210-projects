using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "This explained abstraction perfectly!"));
        video1.AddComment(new Comment("Bob", "Short, sweet, and to the point. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a follow up on encapsulation?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Indie Games of 2026", "GamerCentral", 1200);
        video2.AddComment(new Comment("David", "The third game on the list looks incredible. Adding to wishlist"));
        video2.AddComment(new Comment("Emma", "Awesome video edit style, keep it up."));
        video2.AddComment(new Comment("Frank", "Glad to see small developers getting some love here."));
        videos.Add(video2);

        Video video3 = new Video("How to Bake Perfect Sourdough Bread", "ChefClaire", 1800);
        video3.AddComment(new Comment("Grace", "My crust finally turned out crispy after following this."));
        video3.AddComment(new Comment("Henry", "What brand of flour do you recommend?"));
        video3.AddComment(new Comment("Isla", "Tried this morning, tastes delicious!"));
        videos.Add(video3);

        Console.WriteLine("Tracking Placement of Products in YouTube Videos:\n");
        Console.WriteLine(new string('-', 40));

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}