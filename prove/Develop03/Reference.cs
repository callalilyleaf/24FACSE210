using System;
using System.Collections.Generic;

class Reference{
    private Dictionary <string, string> _refAndVer = new Dictionary<string, string>(){{"Genesis 1:1", "In the beginning God created the heaven and the earth."}};
    
    // After success: Add the scripture  reference and version to the dictionary

    public string GetReference()
    {

        foreach (KeyValuePair<string, string> pair in _refAndVer)
        {   
            Random rand = new Random();
            return _refAndVer.ElementAt(rand.Next(0, _refAndVer.Count)).Key;
            // return a random pair key (which is the reference of a scripture)
        }

    }

    public string GetVerse()
    {

        foreach (KeyValuePair<string, string> pair in _refAndVer)
        {   
            Random rand = new Random();
            return _refAndVer.ElementAt(rand.Next(0, _refAndVer.Count)).Value;
            // return a random pair value (which is the verse of a scripture)
        }

    }
 
}