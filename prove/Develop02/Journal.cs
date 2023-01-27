using System;
using System.Collections.Generic;
using System.IO;
public class Journal 
{
    // Create Attributes
    private static List<string> _journalEntries = new List<string>();

    // Create Methods
    public static void JournalMenu()
    {
        string choice = "7";
        while (choice != "5")
        {
            Console.WriteLine("1 : Make a new journal entry");
            Console.WriteLine("2 : Display journal entries on file");
            Console.WriteLine("3 : Save current journal to file");
            Console.WriteLine("4 : Load in a previous journal file ");
            Console.WriteLine("5 : Exit journal");
            Console.WriteLine("");
            Console.Write("Enter the number of the menu option above: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                GetEntry2();
            }
            else if (choice == "2")
            {
                DisplayEntries();
            }
            else if (choice == "3")
            {
                SaveEntiresToFile();
            }
            else if (choice == "4")
            {
                LoadPastEntries();
            }
            else if (choice == "5")
            {
                Console.Write("Bye Bye");
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                choice = "7";
            }
            
        }
        
    }
    private static void GetEntry2()
    {
        string completeEntry = Entry.GetEntry();
        _journalEntries.Add(completeEntry);
        Console.WriteLine("Your entry has been recorded.");
        Console.WriteLine("");
    }

    private static void DisplayEntries()
    {
        foreach(string entry in _journalEntries)
        {
            Console.WriteLine($"*{entry}");
        }
    }

    private static void SaveEntiresToFile()
    {
        DateTime currentDate = DateTime.Now;
        string dateString = currentDate.ToString("MM-dd-yyyy");
        Console.WriteLine("Save entries as: ");
        string filename = Console.ReadLine();
        File.AppendAllLines($"{filename}{dateString}.txt", _journalEntries);
    }

    private static void LoadPastEntries()
    {
        Console.WriteLine("Enter the filename of your past journal");
        Console.WriteLine("or");
        Console.WriteLine("the date of the entries in this format mm-dd-yyyy");
        Console.WriteLine("Here: ");
        string fileName = Console.ReadLine();

        string[] fileNames = Directory.GetFiles(Directory.GetCurrentDirectory());
        foreach(string file in fileNames)
        {
            if(file.Contains(fileName))
            {
                _journalEntries.Clear();
                foreach(string line in File.ReadLines(file))
                {
                    _journalEntries.Add(line);
                }
            }
        }
            
    }

}