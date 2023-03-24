public class SimpleGoal : Goal{
    // Constructor Methods
    public SimpleGoal() : base(){
        
    }
    public SimpleGoal(int goalType, string goalName, string goalDescription, int pointsPerEvent, int tillCompleted, int amountCompleted, bool isComplete) : base(goalType,goalName,goalDescription,pointsPerEvent,tillCompleted,amountCompleted,isComplete){
    }
}