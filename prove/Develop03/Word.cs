using System;
using System.Data;
using System.Runtime.Serialization.Formatters;

class Word{
    Reference reference1 = new Reference();

    public Word()
    {
        SeparateVerse();
    }
        private List<string> _verse = new List<string>(); // Waited to be put separated words from the verse in it.
        private List<int> _usedIndexes = new List<int>(); // Store the used indexes of hidden words
        private List<int> availableIndexes = new List<int>();


    // private int max_index = 0; // store for the max index of the verse words
    public string Get_Verse()
    {   
        return reference1.GetVerse();
    }

    public List<string> Get_Verse_List()
    {   
        return _verse;
    }

    public void SeparateVerse()
    {
        // Split the verse into words and store them in the _verse list.
        string content = reference1.GetVerse();
        _verse = content.Split(" ").ToList();

        // Figure out how to separate the verse into words by multiple different charactersx
    } 
    public void setAvailableIndexes()
    { 
        for (int i = 0; i < _verse.Count; i++)
        {
            availableIndexes.Add(i);
        }
    }

    public List<string> HideWords()
    {
        // task 1: get the random, non-repeated 3 indexes from the verse.Count()

        
        Random random = new Random();
  
            // if (availableIndexes.Count == 0)
            // {
            //     break; //Exit the loop if there are no more available indexes
            // }
            var randomPosition = availableIndexes.OrderBy(x => random.Next()).Take(3).ToList();
            // int randomPosition = random.Next(0, availableIndexes.Count); // Create a random position for the index
            _usedIndexes.AddRange(randomPosition);
            // Put the random position in the usedIndexes list
            availableIndexes = availableIndexes.Except(randomPosition).ToList();
            // Remove the used index so it won't be used again   


        // task 2: change the word to the underscores
        foreach (int i in _usedIndexes)
        {
            string masked = new string('_', _verse[i].Length); // Create a string of underscores with the same length as the word
            _verse[i] = masked;
        }

        // task 3: return the verse
        
        return _verse;
    }

    public void RevealHiddenWords()
    {
        _usedIndexes.Clear();
    }

    // Stretch: using multiple characters to separate the verse into words. For example: comma(,), blank( ), semicolon(;), colon(:), etc.

    public bool Status()
    {
        return _usedIndexes.Count() == _verse.Count();
    }
}