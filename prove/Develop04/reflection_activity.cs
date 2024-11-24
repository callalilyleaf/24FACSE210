using System.Diagnostics;

public class Reflection : Activity
{   
    public Reflection() // set the welcome message and exit message
    {   
        
        _activityName = "Reflection";
        _explanation = "This activity will help you reflect on times in your life when you hae shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    List<string> reflectionPrompts = new List<string>
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    List<string> AnswerPrompts = new List<string>
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    public void PreReflect() //  do reflection activity preparation
    {   
        Random random = new Random();
        string prompt = reflectionPrompts[random.Next(reflectionPrompts.Count)];
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {prompt} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n");
        Console.WriteLine("You may begin in: ");
        Counter();

    }

    public void Reflect()
    {   
        Random random = new Random();
        var randomindex = Enumerable.Range(0, AnswerPrompts.Count)
                                    .OrderBy(x => random.Next())
                                    .Take(AnswerPrompts.Count - 1)
                                    .ToList(); // get all AnswerPrompt indexes randomly

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_lasttime);
        Console.Clear();
        
        foreach (int i in randomindex)
        {   
            Console.WriteLine($"> {AnswerPrompts[i]}"); 
            Spinner(7); //pondering 1 question takes 7 seconds in average
            if (DateTime.Now > endTime)
            {
                break;
            }
        }
    
    }
}