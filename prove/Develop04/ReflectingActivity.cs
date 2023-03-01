using System;

internal class ReflectingActivity : Activity{
    // Functional Methods
    public void StartReflectingActivity(){
        base.DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        Console.Write("-"); base.DisplayRandomPrompt(_reflectPrompts, 1); Console.WriteLine("");
        Console.WriteLine("When you have thought of something press enter to contine.\n"); Console.ReadLine();
        Console.WriteLine("Now meditate on the following questions related to this experience");
        Console.Write("You may begin in: ");
        base.DisplayCountDown(5);
        Console.Clear();
        DisplayDigDeeperPrompts(_digDeeper, 4);
        base.DisplayEndingMessage();
    }
    private void DisplayDigDeeperPrompts(List<string> prompts, int promptQuantity){
        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        while (DateTime.Now < endTime) {
        Random random = new Random();
        int count = prompts.Count;
        while (count > 0){
            if(promptQuantity > 0)
            {
                int index = random.Next(count);
                Console.Write(prompts[index]);
                base.DisplaySpinner();
                base.DisplaySpinner();
                base.DisplaySpinner();
                Console.WriteLine("");
                prompts[index] = prompts[count - 1];
                count--;
                promptQuantity--;
            }else{
                return;
            }
        }
            }
    }

    // Member Variables
    List<string> _reflectPrompts = new List<string> {"Think of a time when you did something difficult.", "Recall a time when you made a sacrificial decision.", "Remember a time when you faced a challenging situation."};
    List<string> _digDeeper = new List<string> {"> What motivated you to do what you did?", "> What did you learn from the experience?", "> How did the experience change you?", "> Would you do it again? Why or why not?"};
    // Constructor Methods
    public ReflectingActivity(){
        base._activityName = "Reflecting Activity";
        base._description = "reflect on times in your life when you have shown strength and resilience. It will help you to recognize the power that you have and how you can use it to do good things with your life.";
    }
}