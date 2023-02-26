using System;

internal class ReflectingActivity : Activity{
    // Functional Methods
    public void StartReflectingActivity(){
        base.DisplayStartingMessage();
        base.DoForXAmountOfTime();
        base.DisplayEndingMessage();
    }
    private void DisplayReflectPrompts(){
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine()
    }

    // Member Variables
    List<string> reflectPrompts = new List<string> {"Think of a time when you did something difficult.", "Recall a time when you made a sacrificial decision.", "Remember a time when you faced a challenging situation."};
    List<string> digDeeper = new List<string> {}
    // Constructor Methods
    public ReflectingActivity(){
        base._activityName = "Reflecting Activity";
        base._description = "reflect on times in your life when you have shown strength and resilience. It will help you to recognize the power that you have and how you can use it to do good things with your life.";
    }
}