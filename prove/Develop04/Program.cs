// To exceede requirements I made it so that when I get random promps from a list that it makes sure to use 
// each prompt at least once before reapeating it. I did this by taking the item at the end of the list
// and moving it to the spot of the one that I just used and then lowering the list count by one each time.
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
            if(choice == "3" ){
                Console.Clear();
                ListingActivity obj = new ListingActivity();
                obj.StartListingActivity();

            }
        }while(choice != "4");
        
    }
}