using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        // Creativity: Added level system based on score
        // Level increases every 1000 points to motivate the user
    }
}