using System;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int num = PromptUserNumber();
            int numSquared = SquareNumber(num);
            DisplayResults(name, numSquared);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!!!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int num)
        {
            int numSquared = num * num;
            return numSquared;
        }

        static void DisplayResults(string name, int numSquared)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Number Squared: {numSquared}");
        }
        Main();



    }
}