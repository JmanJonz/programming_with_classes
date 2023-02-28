using System;

internal class ReflectingActivity : Activity{
    // Functional Methods
    public void StartReflectingActivity(){
        base.DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        Console.Write("---"); base.DisplayRandomPrompt(_reflectPrompts, 2); Console.Write("---");
        // base.DoForXAmountOfTime(DisplayReflectPrompts, base._duration);
        base.DisplayEndingMessage();
    }
    private void DisplayReflectPrompts(){
    }

    // Member Variables
    List<string> _reflectPrompts = new List<string> {"Think of a time when you did something difficult.", "Recall a time when you made a sacrificial decision.", "Remember a time when you faced a challenging situation."};
    List<string> _digDeeper = new List<string> {"What motivated you to do what you did?", "What did you learn from the experience?", "How did the experience change you?", "Would you do it again? Why or why not?"};
    // Constructor Methods
    public ReflectingActivity(){
        base._activityName = "Reflecting Activity";
        base._description = "reflect on times in your life when you have shown strength and resilience. It will help you to recognize the power that you have and how you can use it to do good things with your life.";
    }
}