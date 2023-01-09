using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float percentagenum = Single.Parse(percentage);
        if (percentagenum >= 90)
        {
            letter = "A";
        }
        else if (percentagenum >= 80)
        {
            letter = "B";
        }
        else if (percentagenum >= 70)
        {
            letter = "C";
        }
        else if (percentagenum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}");
    }   
}