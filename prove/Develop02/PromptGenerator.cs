using System;
using System.Collections.Generic;

public class JournalPromptGenerator
{
    //Attributes
    private List<string> prompts = new List<string>() {
        "Write about a memorable experience from your childhood.",
        "Describe a person who has had a significant impact on your life.",
        "Reflect on a time when you overcame a challenge.",
        "Write about a place that holds special meaning to you.",
        "What are you grateful for today?"
    };
    //Metods
    public string GetRandomPrompt()
    {
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}