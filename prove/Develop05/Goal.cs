public class Goal{
    // Functional Methods
    public virtual int RecordEvent(){
        if(IsComplete() == false){
            _goalEventsCompleted++;
        return _goalPointsPerEvent;
        }else{
            Console.WriteLine("You already completed this goal...");
            return 0;
        }
    }
    public virtual bool IsComplete(){
        if(_goalEventsCompleted >= _goalEventsTillCompleted){
            _goalIsComplete = true;
        }
        return _goalIsComplete;
    }

    // Member Variables
    protected int _goalType = 1;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPointsPerEvent;
    protected  int _goalEventsTillCompleted = 1;
    protected int _goalEventsCompleted = 0;
    protected bool _goalIsComplete = false;

    // Getter & Setter Methods
    public int GetGoalType(){
        return _goalType;
    }
    public string GetGoalName(){
        return _goalName;
    }
    public string GetGoalDescription(){
        return _goalDescription;
    }
    public int GetGoalPointsPerEvent(){
        return _goalPointsPerEvent;
    }
    public int GetTimesTillCompleted(){
        return _goalEventsTillCompleted;
    }
    public int GetTimesCompleted(){
        return _goalEventsCompleted;
    }
    public bool GetGoalIsComplete(){
        return _goalIsComplete;
    }

    // Constructor Methods
    public Goal(){

        Console.Write("Enter the name of your goal: ");
        _goalName = Console.ReadLine();

        Console.Write("Enter a short description for this goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points do you want per goal event accomplished? ");
        _goalPointsPerEvent = int.Parse(Console.ReadLine());
    }
    public Goal(int goalType, string goalName, string goalDescription, int pointsPerEvent, int tillCompleted, int amountCompleted, bool isComplete){
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPointsPerEvent = pointsPerEvent;
        _goalEventsTillCompleted = tillCompleted;
        _goalEventsCompleted = amountCompleted;
        _goalIsComplete = isComplete;
    }
}