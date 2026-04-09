using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a moment you felt truly happy."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn from this?",
        "How did you feel at the time?",
        "What made this experience special?"
    };

    private Random _rand = new Random();

    public ReflectingActivity()
        : base("Reflecting", "This activity helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"> {GetRandomPrompt()}");

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{GetRandomQuestion()} ");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }
}