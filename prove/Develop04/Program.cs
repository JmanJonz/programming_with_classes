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
                Console.Clear();
                BreathingActivity obj = new BreathingActivity();
                obj.StartBreathingActivity();
            }
            if(choice == "2"){
                Console.Clear();
                ReflectingActivity obj = new ReflectingActivity();
                obj.StartReflectingActivity();
            }
            // if(choice == ){
                Console.Clear();

            // }
        }while(choice != "4");
        
    }
}