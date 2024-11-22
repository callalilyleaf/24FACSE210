using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


class Reference{
    private int index;
    private string _reference;
    private string _verse;
    
    // public Reference() // scripture indexes: 2-41996
    // {   
    //     string csvFilePath = "lds-scriptures.csv";

    //     try 
    //     {
    //         // Read all lines at once to avoid multiple file reads
    //         string[] lines = File.ReadAllLines(csvFilePath);

    //         // Ensure we're using a valid random index
    //         Random random = new Random();
    //         int randomIndex = random.Next(1, lines.Length); // Start from 1 to skip header

    //         // Split the randomly selected line
    //         string[] allLines = lines[randomIndex].Split(',');

    //         // Ensure array has enough elements before accessing
    //         if (allLines.Length >= 18) // Assuming indexes 16 and 17 exist
    //         {
    //             _reference = allLines[16]; 
    //             _verse = allLines[17];
    //         }
    //         else 
    //         {
    //             // Handle cases where the line doesn't have enough elements
    //             Console.WriteLine("Selected line does not have enough elements.");
    //         }
    //     }
    //     catch (FileNotFoundException)
    //     {
    //         Console.WriteLine("CSV file not found.");
    //     }
    //     catch (IOException ex)
    //     {
    //         Console.WriteLine($"Error reading file: {ex.Message}");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Unexpected error: {ex.Message}");
    //     }
    // }

    // public Reference() // scripture indexes: 2-41996
    // {   
    //     string csvFilePath = "lds-scriptures.csv";
    //     using (var reader = new StreamReader(csvFilePath)) //using a reader to read the file
    //     { 
 
    //         Random random = new Random();
    //         int randomIndex = random.Next(1, 41995); //random index between 1 and 41995
    //         for (int i = 0; i < randomIndex; i++)
    //         {
    //             reader.ReadLine(); //skipping the lines before the random index
    //             Console.WriteLine(i);
    //         }

    //         string line = reader.ReadLine(); // This is the random line we want
    //         List<string> allLines = line.Split(",").ToList();
    //         _reference = allLines[16]; // index 16 is the verse and 17 is the reference
    //         _verse = allLines[17];

    //         Console.WriteLine(_reference);
    //         Console.WriteLine(_verse);
    //         Console.ReadLine();
    //     }
    // }
    // }
    public Reference()
    {
       _reference = "Proverbs 3:5-6";
       _verse = "Trust in the Lord with all your heart, And lean not on your own understanding; In all your ways acknowledge Him, And He shall direct your paths.";
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetReference(string reference)
    {   
        _reference = reference;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }   

    // Stretch: 
    // Using dictionary to store references and verses
    private Dictionary <string, string> _referenceAndVerse;

    // Stretch: using the whole scripture reference

    // Stretch 2: using the customerized scripture reference
    // public Reference(string csvFilePath) // in case of the user wants to have a custom path
    // {   

    //     using(var reader = new StreamReader(csvFilePath))
    //     {
    //         while(!reader.EndOfStream)
    //         {
    //             var line = reader.ReadLine();
    //             var referenceAndVerse = line.Split(",");

    //             _referenceAndVerse.Add(referenceAndVerse[0], referenceAndVerse[1]);
    //         }
    //     }

    // }
    
    // Stretch: return a random pair key (which is the reference of a random scripture)
    // public string GetReference()
    // {

    //     foreach (KeyValuePair<string, string> pair in _referenceAndVerse)
    //     {   
    //         Random rand = new Random();
    //         return _referenceAndVerse.ElementAt(rand.Next(0, _referenceAndVerse.Count)).Key;
    //         // return a random pair key (which is the reference of a scripture)
    //     }

    // }

    // return a random pair value (which is the verse of a random scripture)
    // public string GetVerse()
    // {

    //     foreach (KeyValuePair<string, string> pair in _referenceAndVerse)
    //     {   
    //         Random rand = new Random();
    //         return _referenceAndVerse.ElementAt(rand.Next(0, _referenceAndVerse.Count)).Value;
    //         
    //     }

    // }

 
}