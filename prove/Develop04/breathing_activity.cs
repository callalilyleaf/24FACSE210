using System.Diagnostics;

public class Breathing : Activity
{    
    public Breathing() // set the welcome message and exit message
    {   
        _activityName = "Breathing";
        _explanation = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    public void BreathInOut() // print out the breathing animation
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_lasttime);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(2);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreath in...");
            Spinner(5);

            Console.WriteLine("Now breath out...");
            Spinner(5);
        }

    }

    



    
}