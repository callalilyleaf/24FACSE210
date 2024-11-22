using System.Diagnostics;

public class Reflection : Activity
{   
    public Reflection
    {
        private new string _activityName = "Reflection";
        private string _explanation = "This activity will help you reflect on times in your life when you hae shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
        private new string _endingMessage = $"Well done!!\nYou have completed another {_lasttime} seconds of Reflection Activity.\n";
    }

    List<string> reflectionPrompt = new List<string>
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    List<string> AnswewrPrompt = new List<string>
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

    public void iterate_Reflection() //  Running the reflection activity
    {
        Console.WriteLine("Welcome to the Reflection Activity!\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        int iterationTimer = timer(lasttime); // Set the iteration time
    }
}