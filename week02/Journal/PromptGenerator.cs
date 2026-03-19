using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person today?",
        "What was the best part of today?",
        "What did you learn today?",
        "What made you happy today?",
        "What challenge did you face today?",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        return _prompts[index];
    }
}