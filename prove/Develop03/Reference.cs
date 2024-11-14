using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Reference{
    private int index;
    private Dictionary <string, string> _referenceAndVerse;

    Reference()
    {   
        string csvFilePath = "lds-scriptures.csv";
        using(var reader = new StreamReader(csvFilePath))
        {
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var referenceAndVerse = line.Split(",");

                _referenceAndVerse.Add(referenceAndVerse[0], referenceAndVerse[1]);
            }
        }

    }
    
    public Reference(string csvFilePath)
    {   

        using(var reader = new StreamReader(csvFilePath))
        {
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var referenceAndVerse = line.Split(",");

                _referenceAndVerse.Add(referenceAndVerse[0], referenceAndVerse[1]);
            }
        }

    }
    
    // After success: Add the scripture references and verses to the dictionary by reading the csv file

    public string GetReference()
    {

        foreach (KeyValuePair<string, string> pair in _referenceAndVerse)
        {   
            Random rand = new Random();
            return _referenceAndVerse.ElementAt(rand.Next(0, _referenceAndVerse.Count)).Key;
            // return a random pair key (which is the reference of a scripture)
        }

    }

    public string GetVerse()
    {

        foreach (KeyValuePair<string, string> pair in _referenceAndVerse)
        {   
            Random rand = new Random();
            return _referenceAndVerse.ElementAt(rand.Next(0, _referenceAndVerse.Count)).Value;
            // return a random pair value (which is the verse of a scripture)
        }

    }
 
}