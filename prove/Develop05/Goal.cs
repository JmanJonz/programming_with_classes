public class Goal{
    // Functional Methods
    public virtual int RecordEvent(){
        _goalEventsCompleted++;
        return _goalPointsPerEvent;
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
    public string Get_goalName(){
        return _goalName;
    }
    public string Get_goalDescription(){
        return _goalDescription;
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
}