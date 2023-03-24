using System;

class Program
{
    // Creativity: In order to show creativity and exceed requirements I made it so that
    // the program keeps track of a running total of all the goals that the user has completed
    // accross all goal lists that they have created and I display it above the main menu. This
    // could be a nice feature to have as the user might have multiple lists of different goals 
    // and it could be rewarding to see the running total. 
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