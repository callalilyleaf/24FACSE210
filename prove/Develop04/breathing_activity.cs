using System.Diagnostics;

public class Breathing : Activity
{    
    public Breathing() // set the welcome message and exit message
    {
        private new string _activityName = "Breathing";
        private string _explanation = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
        private new string _endingMessage = $"Well done!!\nYou have completed another {_lasttime} seconds of Breathing Activity.\n";

    }

    private int breathtime = timer(int lasttime) : base(lasttime); //Set the time for inhaling and exhaling

    
    public void breathIn() // print out the breathing animation
    {
        // an animation that gets higher, ask AI
    }


    
    public void breathOut() // print out the breathing animation
    
    {
        // an animation that gets lower, ask AI
    } 


    
}