public class ChecklistGoal : Goal{
    // Functional Methods
    public override int RecordEvent(){
        base._goalEventsCompleted++;
        _completeRatio = $"{base._goalEventsCompleted}/{base._goalEventsTillCompleted}"; 
        return base._goalPointsPerEvent;
    }

    // Member Variables
    private string _completeRatio;
    private int _cGBounusPoints;

    // Getter And Setter Methods
    public string GetCompleteRatio(){
        return _completeRatio;
    }
    public int GetCGBonusPoints(){
        return _cGBounusPoints;
    }


    // Constructor Methods
    public ChecklistGoal(){
        Console.Write("How many times must you do this behavior for you to complete your goal? ");
        base._goalEventsTillCompleted = int.Parse(Console.ReadLine());
        _completeRatio = $"{base._goalEventsCompleted}/{base._goalEventsTillCompleted}";
        Console.Write("How many bonus points would you like to recieve for completing this Check List Goal? ");
        _cGBounusPoints = int.Parse(Console.ReadLine());
    }
}