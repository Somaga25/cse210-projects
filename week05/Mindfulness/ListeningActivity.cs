using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List things you are grateful for.",
        "List people who have influenced you.",
        "List things you enjoy doing."
    };

    private Random _rand = new Random();

    public ListingActivity()
        : base("Listing", "This activity helps you list positive things in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"> {GetRandomPrompt()}");

        Console.WriteLine("\nStart listing items:");
        ShowCountDown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}