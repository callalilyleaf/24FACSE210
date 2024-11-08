using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Operate
{   
    private string _welcome_message = "Welcome to Mindfullness activity!";
    private string _menu = "Menu Options:\n  1.Start breathing activity\n  2.Start reflecting activity\n  3.Start listing activity\n  4.Quit\nSelect a choice from the menu: ";

    private bool pick = false;

    public int GetUserChoice() // Get the user choice and handle error
    {   
        int choice = 0;
        Console.WriteLine(_menu);
        while (!pick)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {   
                choice = number;
                pick = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice with number input.");
            }
        }
        return choice;
    } 

    public void main()
    {
        Console.WriteLine(_welcome_message);
        GetUserChoice(); // Put the choice value to the activity objects
    }

}

