using System;

internal class ListingActivity : Activity{
    // Functional Methods
    public void StartListingActivity(){
        base.DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.Write("-"); base.DisplayRandomPrompt(_goodThingsStrings, 1);
        Console.WriteLine("You can begin in:");
        base.DisplayCountDown(7);
        base.DoForXAmountOfTime(ListGoodThings, _duration);
        Console.WriteLine($"You listed {_inputCount} items!\n");
        base.DisplayEndingMessage();
    }
    private void ListGoodThings(){
        Console.Write("> ");
        Console.ReadLine();
        _inputCount++;
    }

    // Member Variables
    private List<string> _goodThingsStrings = new List<string> {"When has someone done something nice for you over this last week?", "What blessings do you have in your life today?", "What reasons do you have to be hopeful for the future?", "Who do you care about?"};
    private int _inputCount = 0;

    // Constructor Methods
    public ListingActivity(){
        base._activityName = "Listing Activity";
        base._description = "to reflect on the good things in your life by having you list as many things as you can for a certain part of your life";
    }
}