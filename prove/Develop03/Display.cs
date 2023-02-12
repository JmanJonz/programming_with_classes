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
                break;
                Console.ReadLine();
                Console.WriteLine(wordsObj.HideWords());
                Console.WriteLine("");
        }
        while(allUnderscores == false);

  

    }
    
}
