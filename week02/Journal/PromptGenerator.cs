using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "Did I help anyone today? How?",
            "What was the most challenging part of my day?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What can I inmprove on tomorrow?",
            "What made me smile today?",
            "How can I be a good leader?",

        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}