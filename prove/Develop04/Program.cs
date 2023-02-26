using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        do{
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice here: ");
            choice = Console.ReadLine();

            if(choice == "1" ){
                BreathingActivity obj = new BreathingActivity();
                obj.StartBreathingActivity();
            }
            // if(choice == ){

            // }
            // if(choice == ){

            // }
        }while(choice != "4");
        
    }
}