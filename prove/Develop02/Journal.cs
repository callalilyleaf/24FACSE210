using System;
using System.IO;
using System.IO.Enumeration;

public class Journal
{   
    private List<string> _entries = new List<string>();
    // Create a list called entries that stores entry objects
    
    private List<string> _oldentries = new List<string>();
    // Create a list called oldentries that stores previous entry objects

    private PromptManager pm = new PromptManager();

    public void AddEntry()
    {
        string prompt = pm.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string dateText = DateTime.Now.ToShortDateString();
        string entry = $"Date: {dateText} - Prompt: {prompt}\n{response}";
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        bool _isDone = false;

        while (!_isDone)
        {
            Console.WriteLine("Which one do you want to display?\n 1.Today\n 2.Previous (Choose this one if you already loaded a file)\n(please enter number) ");
            string displaychoice = Console.ReadLine();

            if(displaychoice == "1")
            {
                foreach(string text in _entries)
                {
                    Console.WriteLine(text);
                }
                _isDone = true;
            }

            else if(displaychoice == "2")
            {
                if (_oldentries.Count == 0)
                {    
                    LoadFromFile();
                }
                foreach(string text in _oldentries)
                {
                    Console.WriteLine(text);
                }
                _isDone = true;
            }

            else
            {
                Console.WriteLine("Umm...You're dumb...\nPlease enter valid number option");
            }
        } 


    }

    public void SaveToFile()
    {
        Console.WriteLine("What's the filename? (without the file type)");
        string filename = $"{Console.ReadLine()}.txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string text in _entries)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(text);
            }
        }
    }

    public void LoadFromFile()
    {
        bool isLoad = false;

        while (!isLoad)
        {
            Console.WriteLine("What's the filename? \n(only txt file. Please enter the file name without '.txt')\ntype 'quit' to quit.");
            string filename = Console.ReadLine();

            if (filename.ToLower() == "quit")
            {
                Console.Clear();
                break;
            }

            else if (!File.Exists($"{filename}.txt"))
            {
                Console.WriteLine($"\nThe file doesn't exist.\nPlease check if there's a typo and make sure it's in the same folder of this program: \n{filename}.txt\n");
            }

            else
            {
                string[] lines = File.ReadAllLines($"{filename}.txt");

                foreach (string line in lines)
                {
                    _oldentries.Add(line);
                }
                Console.WriteLine("File successfully loaded\n");
                isLoad = true;
            }
        }
       
    }



}