using System;
using System.Collections.Generic;

public class JournalPromptGenerator
{
    //Attributes
    private static List<string> _prompts = new List<string>() {
        "Write about a memorable experience from your childhood.",
        "Describe a person who has had a significant impact on your life.",
        "Reflect on a time when you overcame a challenge.",
        "Write about a place that holds special meaning to you.",
        "What are you grateful for today?"
    };
    //Metods
    public static string GetRandomPrompt()
    {
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}