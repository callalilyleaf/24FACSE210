using System;

class Word{
    Reference reference = new Reference();

    private List<string> _verse = []; // Waited to be put separated words from the verse in it.

    private List<int> _usedIndexes = []; // Store the used indexes of hidden words

    void SeparateVerse()
    {
        // Split the verse into words and store them in the _verse list.
        string content = reference.GetVerse();
        _verse = content.Split(string[], Int32, StringSplitOptions options =[",",";",":"]);
        // Figure out how to separate the verse into words by multiple different charactersx
    }

}