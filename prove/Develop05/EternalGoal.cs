public class EternalGoal : Goal{
    // Functional Methods
    public override bool IsComplete()
    {
        return false;
    }
    // Constructor Methods
    public EternalGoal() : base(){
        
    }
    public EternalGoal(int goalType, string goalName, string goalDescription, int pointsPerEvent, int tillCompleted, int amountCompleted, bool isComplete) : base(goalType,goalName,goalDescription,pointsPerEvent,tillCompleted,amountCompleted,isComplete){
    }
}