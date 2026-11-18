using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Coding tutorials", "Fred Barkley", 360);
        video1.AddComment(new Comment("David", "Great explanation of classes!"));
        video1.AddComment(new Comment("Jim", "This helped me understand C# constructors."));
        video1.AddComment(new Comment("Christopher", "Clear and easy to follow."));
        videos.Add(video1);

        Video video2 = new Video("Product Reviews", "Ashley Nimson", 670);
        video2.AddComment(new Comment("Todd", "Super helpful review, thanks for testing the battery life!"));
        video2.AddComment(new Comment("Prince", "I've been thinking about buying this—great breakdown."));
        video2.AddComment(new Comment("Jessie", "How does it compare to last year's model?"));
        videos.Add(video2);

        Video video3 = new Video("football highlights", "Mike Davies", 900);
        video3.AddComment(new Comment("Jack", "That last-minute goal was unbelievable!"));
        video3.AddComment(new Comment("Freddie", "Best match of the season so far."));
        video3.AddComment(new Comment("Nicole", "The goalkeeper saved them in the second half."));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}