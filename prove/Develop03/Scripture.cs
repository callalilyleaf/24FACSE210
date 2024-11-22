public class Scripture
{
    private string _reference;
    private List<string> _hiddenVerse;

    Word words = new Word();

    public Scripture()
    {
        GetReference();
    }

    public void GetReference()
    {
        Reference refObj = new Reference();
        _reference = refObj.GetReference();
        _hiddenVerse = words.Get_Verse_List();
    }

    public void setAvaliableIndex()
    {
        words.setAvailableIndexes();
    }

    public void DisplayScripture()
    {   
        
        Console.WriteLine(_reference + " ");
        _hiddenVerse = words.HideWords();
        foreach (string word in _hiddenVerse)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

    public void RevealHiddenWords()
    {   
        Console.WriteLine(_reference + " ");
        Console.WriteLine(words.Get_Verse());
    }


    public bool Status()
    {
        return words.Status();
    }
}