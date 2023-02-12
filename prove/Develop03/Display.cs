using System;

class Display
{
    // Attributes
    // NA because it will use all returns from other classes as things to display

    // Constructors
    // None as there are no attributes this is a utility class
    
    // Methods
    public void DisplayScripture()
    {
        Words wordsObj = new Words();
        string hintt = wordsObj.GetHintToDisplay();
        string refer = wordsObj.GetRefToDisplay();
        // Keep showing list with less words until every word is taken by ___
        bool allUnderscores = true;

        do
        {
            allUnderscores = true;
            foreach(string word in wordsObj.GiveDisplayList())
            {
                foreach(char c in word)
                {
                    if(c != '_')
                    {
                        allUnderscores = false;
                    }
                }
            }
                if (allUnderscores == true)
                {
                    break;
                }
                Console.Write("Enter: h for hint, enter to continue, or q to quit: ");
                string input = Console.ReadLine();
                Console.Clear();
                if (input == "q")
                {
                    Environment.Exit(0);
                }
                else if (input == "h")
                {
                    Console.WriteLine($"Your hint is: {hintt}");
                }
                else
                {
                    Console.WriteLine($"{refer} {wordsObj.HideWords()}");
                    Console.WriteLine("");
                }
            
        }
        while(allUnderscores == false);

  

    }
    
}
