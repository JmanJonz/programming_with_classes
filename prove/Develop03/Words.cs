using System;

class Words
{
    // Attributes
    private List<string> _words = new List<string>();

    // Constructors
    public Words()
    {
        // This calls a function which takes the scripture string and loads each word in the string into the array _words
        SStringToSList();
    }

    // Private Methods
    private void SStringToSList()
    {
        Scripture example = new Scripture("D&C 6:36", "Look unto me in every thought: doubt not, fear not.");
        string scripture = example.GiveScriptureToWords();
        foreach(string word in scripture.Split(" "))
        {
            _words.Add(word);
        }
    }

    // Public Methods
    public Scripture sendInstanScriObj()
    {
        
    }
    public string HideWords()
    {
        Random randNum = new Random();
        for(int i = 0; i < 2; i++ )
        {
            int randomIndex = randNum.Next(0,_words.Count);
            int wordLetterCount = _words[randomIndex].Length;
            string wordRepBy_ = "";
            for(int e = 0; e < wordLetterCount; e++ )
            {
                wordRepBy_ += "_";
            }
            _words[randomIndex] = wordRepBy_;
        }
        return string.Join(" ", _words);
    }
    public List<string> GiveDisplayList()
    {
        return _words;
    }

}