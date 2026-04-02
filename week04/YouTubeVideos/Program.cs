using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learning C#", "John Doe", 600);
        v1.AddComment(new Comment("Alice", "Great video!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Eve", "Nice explanation."));

        Video v2 = new Video("OOP Basics", "Jane Smith", 800);
        v2.AddComment(new Comment("Tom", "Awesome content."));
        v2.AddComment(new Comment("Jerry", "Loved it."));
        v2.AddComment(new Comment("Mike", "Clear and simple."));

        Video v3 = new Video("Data Structures", "David Lee", 700);
        v3.AddComment(new Comment("Anna", "Very informative."));
        v3.AddComment(new Comment("Chris", "Thanks!"));
        v3.AddComment(new Comment("Sam", "Good job."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}