using System;

public class Menu
{
    private string _welcome = "Welcome to the Journal Program!\n";
    private string _menu = "Please select one of the following choice: \n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would you like to do? ";

    private bool _isDone = false;

    public void HandleSelection()
    {   
        Journal _journal = new Journal();
        Console.WriteLine(_welcome);
        
        while(!_isDone)
        {
            Console.WriteLine(_menu);
            string selection = Console.ReadLine();

            if(selection == "1")
            {
                _journal.AddEntry();
            }

            else if(selection == "2")
            {
                _journal.DisplayEntries();
            }

            else if(selection == "3")
            {
                _journal.SaveToFile();
              
            }

            else if(selection == "4")
            {
                _journal.LoadFromFile();
            }

            else if(selection == "5")
            {
                _isDone = true;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid choice");
                Thread.Sleep(2000);
            }
        
        }   
        Console.WriteLine("Thanks for using, see you tomorrow!");
    }

}
