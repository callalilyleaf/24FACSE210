public abstract class Goal
{
    // attributes for each type of goal:
    // simple: goalTypeName, goalExplanation, eachTimePoints(int), isFinished(bool)
    // eternal: goalTypeName, goalExplanation, eachTimePoints(int) 
    // checklist: goalTypeName, goalExplanaiton, eachTimePoints(int), finishedBonusPoints(int), goalCounts(int), currentCounts(int)

    protected string _goalType; // hardcoded in each goal class
    protected string _goalName;
    protected string _goalExplanation;
    protected int _addPoints; // how many points the user gets for accomplishement each time
    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public string GetGoalExplanation()
    {
        return _goalExplanation;
    }

    public void SetGoalExplanation()
    {
        Console.WriteLine("What is a short description of it? ");
        _goalExplanation = Console.ReadLine();
    }

    public int GetAddPoints()
    {
        return _addPoints;
    }

    public void SetAddPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _addPoints = GetValidInt();
    }

    public int GetValidInt()
    {   
        int outputPoint = -1;
        bool set = false;
        while (!set)
        {
            if (int.TryParse(Console.ReadLine(), out int point) && point > 0) // make sure user sets the points to a positive interger
            {
                outputPoint = point;
                set = true;
            }
            else
            {
                Console.WriteLine("Please insert valid interger number in the range and make sure it's bigger than zero");
            }
        }
        return outputPoint;
    }

    public abstract string AppendGoalToList(); // Append the goal info to _goalInfo List<string>

    public abstract string DisplayGoalList();

    public abstract int GetPlusPoint(int totalPoint); // Get the points and add to the current point. Invoke it when record event is chosen. 

    public abstract void LoadFileGoalInfo(string[] lines); // Use the first word to identify using which class to unzip it. Then, set the goal list (in this program memory) according to the goal info from the loaded file.

    public abstract int RecordGoalProcess(int totalPoints); // return the correct total points


}