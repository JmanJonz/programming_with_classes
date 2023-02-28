using System;

internal class Activity {
    // Functional Methods
    protected int GetActivityDuration() {
        Console.Write("How long should this activity run in seconds? ");
        return int.Parse(Console.ReadLine());
    }
    protected void DoForXAmountOfTime(Action callback, int time) {
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while (DateTime.Now < endTime) {
            callback();
        }
    }
    protected void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_activityName}.\n");
        Console.WriteLine($"This activity will help you {_description}.\n");
        _duration = GetActivityDuration();
        Console.Clear();
        Console.WriteLine("Prepare yourself...");
        DoForXAmountOfTime(DisplaySpinner, 4);
    }
    protected void DisplayEndingMessage(){
        Console.WriteLine("Well Done!");
        DoForXAmountOfTime(DisplaySpinner, 4);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        DoForXAmountOfTime(DisplaySpinner, 4);
    }
    protected void DisplaySpinner(){
        List<char> spinnerChars = new List<char> {'\\','|','/','-'};
        foreach (char dash in spinnerChars){
            Console.Write(dash);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void DisplayCountDown(int seconds){
        for (int i = seconds; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void DisplayRandomPrompt(List<string> prompts, int promptQuantity){
        Random random = new Random();
        int count = prompts.Count;
        while (count > 0){
            if(promptQuantity > 0)
            {
                int index = random.Next(count);
                Console.WriteLine(prompts[index]);
                prompts[index] = prompts[count - 1];
                count--;
                promptQuantity--;
            }else{
                Console.WriteLine("");
            }
        }
    }

    // Member Variables
    protected int _duration;
    protected string _activityName;
    protected string _description;

    // Constructor Methods
        // As per my design _activityName and _description will be set in child constructors
}