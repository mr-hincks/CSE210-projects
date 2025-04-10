using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("C# Tutorial for Beginners", "Programming Master", 1200);
        var video2 = new Video("Learn Python in 10 Minutes", "Code Ninja", 600);
        var video3 = new Video("ASP.NET Core Crash Course", "Web Dev Guru", 1800);
        var video4 = new Video("Machine Learning Basics", "AI Explorer", 2400);

        // Add comments to video1
        video1.AddComment(new Comment("Eric", "Great tutorial!"));
        video1.AddComment(new Comment("Adwoa", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Barima", "Could you make one about OOP?"));

        // Add comments to video2
        video2.AddComment(new Comment("Noela", "Python is awesome!"));
        video2.AddComment(new Comment("Agyeiwaa", "I didn't understand the last part"));
        video2.AddComment(new Comment("Spendylove", "Good content, but too fast"));
        video2.AddComment(new Comment("Maame Afia", "Thanks for sharing"));

        // Add comments to video3
        video3.AddComment(new Comment("Selasie", "Exactly what I needed"));
        video3.AddComment(new Comment("Korkor", "Will there be a part 2?"));
        video3.AddComment(new Comment("Dzifa", "Using this in my class"));

        // Add comments to video4
        video4.AddComment(new Comment("Gloria", "Clear explanation"));
        video4.AddComment(new Comment("Sandra", "Too advanced for me"));
        video4.AddComment(new Comment("Audis", "Good overview of the basics"));

        // Create a list of videos
        var videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
            
            Console.WriteLine(); // Add a blank line between videos
        }
    }
}