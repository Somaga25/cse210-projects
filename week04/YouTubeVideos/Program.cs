using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C#", "Chisomaga Eke", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Eve", "Nice explanation."));

        // Video 2
        Video video2 = new Video("OOP Basics", "Jane Smith", 800);
        video2.AddComment(new Comment("Tom", "Awesome content."));
        video2.AddComment(new Comment("Jerry", "Loved it."));
        video2.AddComment(new Comment("Mike", "Clear and simple."));

        // Video 3
        Video video3 = new Video("Data Structures", "David Lee", 700);
        video3.AddComment(new Comment("Anna", "Very informative."));
        video3.AddComment(new Comment("Chris", "Thanks!"));
        video3.AddComment(new Comment("Sam", "Good job."));

        // Add to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}