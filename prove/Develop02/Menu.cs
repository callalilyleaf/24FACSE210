using System;

public class Menu
{
    public string welcome = "Welcome to the Journal Program!\n";
    public string menu = "Please select one of the following choice: \n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would like to do? ";

    public void HandleSelection()
    {   
        Journal journal = new Journal();
        Console.WriteLine(welcome);
        Console.WriteLine(menu);
        string selection = Console.ReadLine();
        while(selection != "5")
        {
            if(selection == "1")
            {
                journal.AddEntry();
                Console.WriteLine(menu);
                selection = Console.ReadLine();
            }

            else if(selection == "2")
            {
                journal.DisplayEntries();
                Console.WriteLine(menu);
                selection = Console.ReadLine();
            }

            else if(selection == "3")
            {
                journal.SaveToFile();
                Console.WriteLine(menu);
                selection = Console.ReadLine();
            }

            else if(selection == "4")
            {
                journal.LoadFromFile();
                Console.WriteLine(menu);
                selection = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter a valid choice");
            }
        
        }   
        Console.WriteLine("Thanks for using, see you tomorrow!");
    }

}
