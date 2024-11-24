using System.Diagnostics;
using System.Drawing.Text;

public class Listing : Activity
{
    public Listing() 
    {   
        _activityName = "Listing";
        _explanation = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }    
        
    List<string> listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public void ListingAnswers()
    {
        Random random = new Random(); 
        int randomIndex = random.Next(0, listPrompts.Count);

        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {listPrompts[randomIndex]} --- \n");
        Console.WriteLine("You may begin in: ");
        Counter();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_lasttime);
        int counter = 0;

        do
        {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }
        while(DateTime.Now < endTime);

        Console.WriteLine($"You listed {counter} responses in {_lasttime} seconds.");
        Thread.Sleep(4000);
    }
    
}
