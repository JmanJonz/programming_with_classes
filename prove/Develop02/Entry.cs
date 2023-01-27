using System;
using System.Collections.Generic;

public class Entry
{
    public static string GetEntry()
    {
        string prompt = JournalPromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        string dateString = currentDate.ToString("MM/dd/yyyy");
        string completePrompt = $"{dateString} -- {prompt} -- {userInput}";
        return completePrompt;
    }
}