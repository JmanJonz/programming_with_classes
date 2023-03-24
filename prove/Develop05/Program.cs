using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        do{
            Console.WriteLine($"Your score for this goal list is: {GoalInterface.Get_pointsForGoalList()}\nOverall lists you have completed {GoalInterface.Get_numberGoalsCompletedTotal()} goals total.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
                if(option == 1){
                    GoalInterface.CreateGoal();
                }else if(option == 2){
                    GoalInterface.DisplayGoalList();
                }else if(option == 3){
                    GoalInterface.SaveList();
                }else if(option == 4){
                    GoalInterface.LoadList();
                }else if(option == 5){
                    GoalInterface.PerformEventActions();
                }else if(option != 6){
                    Console.WriteLine("Please Enter a valid option.");
                }
            Console.WriteLine("");
            }while(option != 6);

    }
}