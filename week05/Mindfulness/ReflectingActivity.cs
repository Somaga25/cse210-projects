using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this experience special?"
    };

    private Random _rand = new Random();
    private int _lastPromptIndex = -1;
    private int _lastQuestionIndex = -1;

    public ReflectingActivity()
        : base("Reflecting", "This activity helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int promptIndex = GetRandomIndex(_prompts.Count, ref _lastPromptIndex);
        Console.WriteLine("\nConsider this prompt:");
        Console.WriteLine($"> {_prompts[promptIndex]}");

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int questionIndex = GetRandomIndex(_questions.Count, ref _lastQuestionIndex);
            Console.Write($"\n{_questions[questionIndex]} ");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private int GetRandomIndex(int count, ref int lastIndex)
    {
        int newIndex;
        do
        {
            newIndex = _rand.Next(count);
        } while (newIndex == lastIndex);

        lastIndex = newIndex;
        return newIndex;
    }
}