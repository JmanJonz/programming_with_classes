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
            if (goal.IsComplete() && goal is ChecklistGoal){
                ChecklistGoal checkGoal = goal as ChecklistGoal;
                Console.WriteLine($"{countDisplayed}. [X] {checkGoal.GetGoalName()} : {checkGoal.GetGoalDescription()} : {checkGoal.GetCompleteRatio()}");
                countDisplayed++;
            }else if (goal.IsComplete()){
                Console.WriteLine($"{countDisplayed}. [X] {goal.GetGoalName()} : {goal.GetGoalDescription()}");
                countDisplayed++;
            }else if (!goal.IsComplete() && goal is ChecklistGoal){
                ChecklistGoal checkGoal = goal as ChecklistGoal;
                Console.WriteLine($"{countDisplayed}. [ ] {checkGoal.GetGoalName()} : {checkGoal.GetGoalDescription()} : {checkGoal.GetCompleteRatio()}");
                countDisplayed++;
            }else{
                Console.WriteLine($"{countDisplayed}. [ ] {goal.GetGoalName()} : {goal.GetGoalDescription()}");
                countDisplayed++;
            }
        }
    }
    public static void PerformEventActions(){
        DisplayGoalList();
        Console.WriteLine("You completed a task for which goal? ");
        int goalTaskCompleted = int.Parse(Console.ReadLine());
        try{
            if(_listOfGoals[goalTaskCompleted - 1].IsComplete() == false){
                int pointsGot = _listOfGoals[goalTaskCompleted - 1].RecordEvent();
                _pointsForGoalList += pointsGot;
                Console.WriteLine($"Congradulations you earned {pointsGot} points!");
                if(_listOfGoals[goalTaskCompleted - 1].IsComplete()){
                    Console.WriteLine("Congradulations X2! You completed this goal!");
                    _numberGoalsCompletedTotal += 1;
                }
                if(_listOfGoals[goalTaskCompleted - 1] is ChecklistGoal){
                    ChecklistGoal cG = _listOfGoals[goalTaskCompleted - 1] as ChecklistGoal;
                    if(cG.IsComplete()){
                        Console.WriteLine($"Congradulations X3 you won a bonus of {cG.GetCGBonusPoints()}!!!!!");
                        _pointsForGoalList += cG.GetCGBonusPoints();
                    }
                }
            }else{
                Console.WriteLine("You already completed this goal...");
            }
        }catch(Exception ex){
            Console.WriteLine("An exception occurred: " + ex.Message);
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