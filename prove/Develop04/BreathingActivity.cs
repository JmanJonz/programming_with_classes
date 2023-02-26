using System;

internal class BreathingActivity : Activity{
// Functional Methods
public void StartBreathingActivity(){
    base.DisplayStartingMessage();
    base.DoForXAmountOfTime(DisplayBreathingPrompts, _duration);
    base.DisplayEndingMessage();

}
private void DisplayBreathingPrompts(){
    Console.Write("Breathe in...");
    base.DisplayCountDown(5);
    Console.WriteLine("");
    Console.Write("Now breathe out...");
    base.DisplayCountDown(6);
    Console.WriteLine("\n");
}
// Member Variables

// Constructor Methods
public BreathingActivity(){
    _activityName = "Breathing Activity";
    _description = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
}
}