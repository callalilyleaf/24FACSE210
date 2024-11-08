using System;
using System.IO.Compression;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected int lasttime = 0; // in second
    private string _startingMessage = "Welcome to the Mindfulness activity!";
    private string _endingMessage = "Well done!!\nYou have completed another {lasttime} seconds of mindfulness practice.\n";

    public int timer(int lasttime) // Set the duration for the activity time
    {   
        Console.WriteLine("How long, in seconds, would you like for this session? ");
        bool pick = false;
        while (!pick) // handle the error input
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {   
                lasttime = number;
                pick = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice with number input.");
            }
        }
        return lasttime;
    }
    
    public void spinner() // print out the spinner animation    
    {   
        for (int i = lasttime; i > 0; i--)
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