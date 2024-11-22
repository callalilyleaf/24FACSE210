using System.Diagnostics;

public class Listing : Activity
{
    public Listing() 
    {
        private new string _activityName = "Listing";
        private string _explanation = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
        private new string _endingMessage = $"Well done!!\nYou have completed another {_lasttime} seconds of Listing Activity.\n";
    }    
           
        public void getanswerLen()
        {   
            Console.WriteLine("How many answers do you have?");
            private int answerLen = int.Parse(Console.ReadLine());
        }

        List<string> listPrompts = new List<string>();
        public void listAnswer(List list, int answerLen)
        {
            // 
        }
    
}
