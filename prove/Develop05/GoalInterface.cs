// A static GoalInterface class that is used as an instance itself so that the 
// whole program has access to it and so there is only one 
// copy made of it.
public static class GoalInterface{
    // Functional Methods
    public static void CreateGoal(){
        // Local Method Variables
        int goalType;

        // Get the goal type and name of the goal to be created
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Which type would you like to create? ");
        goalType = int.Parse(Console.ReadLine());

        // Create the Goal and add it to _listOfGoals
        if(goalType == 1){
            SimpleGoal newSimpleGoal = new SimpleGoal();
            _listOfGoals.Add(newSimpleGoal);
        }else if(goalType == 2){
            ChecklistGoal newChecklistGoal = new ChecklistGoal();
            _listOfGoals.Add(newChecklistGoal);
        }else if(goalType == 3){
            EternalGoal newEternalGoal = new EternalGoal();
            _listOfGoals.Add(newEternalGoal);
        }else{
            Console.WriteLine("Please enter a valid option");
        }
    }
    public static void DisplayGoalList(){
        int countDisplayed = 1;
        Console.WriteLine("Here is your list of goals: ");
        foreach(Goal goal in _listOfGoals){
            if (goal.IsComplete()){
                Console.WriteLine($"{countDisplayed}. [X] {goal.Get_goalName()} : {goal.Get_goalDescription()}");
                countDisplayed++;
            }else{
                Console.WriteLine($"{countDisplayed}. [ ] {goal.Get_goalName()} : {goal.Get_goalDescription()}");
                countDisplayed++;
            }
        }
    }
    public static void PerformEventActions(){
        DisplayGoalList();
        Console.WriteLine("You completed a task for which goal? ");
        int goalTaskCompleted = int.Parse(Console.ReadLine());
        int pointsGot = _listOfGoals[goalTaskCompleted - 1].RecordEvent();
        _pointsForGoalList += pointsGot;
        Console.WriteLine($"Congradulations you earned {pointsGot} points!");
        if(_listOfGoals[goalTaskCompleted - 1].IsComplete()){
            Console.WriteLine("Congradulations X2! You completed this goal!");
            _numberGoalsCompletedTotal += 1;
        }

    }

    // Member Varialbes
    public static int _pointsForGoalList = 0;
    public static int _numberGoalsCompletedTotal = 0;
    public static List<Goal> _listOfGoals = new List<Goal>{};

    // Getter and Setter Methods
    public static int Get_pointsForGoalList(){
        return _pointsForGoalList;
    }
    public static int Get_numberGoalsCompletedTotal(){
        return _numberGoalsCompletedTotal;
    }
}