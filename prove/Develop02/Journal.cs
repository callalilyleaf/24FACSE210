using System;
using System.IO;
using System.IO.Enumeration;

public class Journal
{   
    public List<string> entries = new List<string>();
    // Create a list called entries that stores entry objects
    
    public List<string> oldentries = new List<string>();
    // Create a list called oldentries that stores previous entry objects

    public PromptManager pm = new PromptManager();

    Menu newmenu = new Menu();

    public void AddEntry()
    {
        string prompt = pm.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string dateText = DateTime.Now.ToShortDateString();
        string entry = $"Date: {dateText} - Prompt: {prompt}\n{response}";
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Which one do you want to display?\n 1.Today \n 2.Previous\n(please enter number) ");
        string displaychoice = Console.ReadLine();
        if(displaychoice == "1")
            foreach(string text in entries)
            {
                Console.WriteLine(text);
            }

        else if(displaychoice == "2")
        {
            if (oldentries.Count == 0)
            {    
                LoadFromFile();
            }
            foreach(string text in oldentries)
            {
                Console.WriteLine(text);
            }
        }

        else
        {
            Console.WriteLine("Umm...You're dumb...");
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("What's the filename? (without the file type)");
        string filename = $"{Console.ReadLine()}.txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string text in entries)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(text);
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What's the filename? (without the file type)");
        string filename = $"{Console.ReadLine()}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            oldentries.Add(line);
        }
        Console.WriteLine("File successfully loaded\n");

    }



}