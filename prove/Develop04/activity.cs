using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected static int _lasttime; // in second
    protected string _activityName;
    protected string _startingMessage;
    protected string _endingMessage;

    public Activity() // Constructor for other activities
    {   
        _startingMessage = $"Welcome to the {_activityName} activity!";
        _lasttime = timer()
        _endingMessage = $"Well done!!\nYou have completed another {_lasttime} seconds of mindfulness practice.\n";
    }
    

    public void timer() // Set the duration for the activity time
    {   
        Console.WriteLine("How long, in seconds, would you like for this session? ");
        bool pick = false;
        while (!pick) // handle the error input
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {   
                int lasttime = number;
                pick = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice with number input.");
            }
        }
        _lasttime = number;
    }
    
    public void spinner() // print out the spinner animation    
    {   
        for (int i = _lasttime; i > 0; i--)
            {
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the previous character
                Console.Write(@"\"); // Replace it with the - characte
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the - character
                Console.Write("/");
            }
    }
    
}