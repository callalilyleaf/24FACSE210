using System;
using System.Drawing;
// using System.Drawing.Common;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected static int _lasttime; // in second
    protected string _activityName;
    protected string _greet;
    protected string _explanation;
    protected string _endingMessage;
    protected List<string> _animationSign = new List<string>
    {"/", "-","\\", "|"};

    public void WelcomeMessage()
    {
        _greet = $"Welcome to the {_activityName} activity.";
        Console.WriteLine($"{_greet}\n\n{_explanation}");
    }

    public void EndMessage()
    {   
         _endingMessage = $"You have completed another {_lasttime} seconds of {_activityName} Activity.";
        Console.WriteLine("\nWell Done!!\n");
        Thread.Sleep(3000);
        Console.WriteLine(_endingMessage);
        Thread.Sleep(3000);
    }

    public void GetTime() // Set the duration for the activity time
    {   
        Console.Write("\nHow long, in seconds, would you like for this session? ");
        bool pick = false;
        while (!pick) // handle the error input
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {   
                pick = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice with number input.");
            }
        _lasttime = number;    
        }
    }
    // Q: In the set time method, should I let it return the value of _lasttime or not?

    public void Counter()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int ms) // print out the spinner animation    
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(ms);
        do
        {
            foreach (string s in _animationSign)
            {
                Console.Write(s);
                Thread.Sleep(125);
                Console.Write("\b \b"); // Erase the previous character
            }

        }while(DateTime.Now < endTime); // run the spinner for 5 seconds
    }

    // stretch: Using GDI+ to do circle animation:
    public void DrawSimpleCircle()
    {
        // Create a bitmap (canvas to draw on)
        Bitmap bitmap = new Bitmap(400, 400);

        // Create graphics object from bitmap
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Create a pen for drawing
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Clear the background
                graphics.Clear(Color.White);

                // Draw circle (when width and height are equal, it becomes a circle)
                // Parameters: pen, x, y, width, height
                graphics.DrawEllipse(pen, 100, 100, 200, 200);
            }
        }

        // Save the result
        bitmap.Save("simple_circle.png");
    }

    
}