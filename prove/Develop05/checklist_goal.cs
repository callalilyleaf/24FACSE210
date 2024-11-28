public class ChecklistGoal : Goal
{
    public ChecklistGoal(string goalType)
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = goalType;
        SetGoalName();
        SetGoalExplanation();
        SetAddPoints();
        SetFinishedBonusPoints();
        SetGoalFinishedCounts();
        ;
        
    }

    public ChecklistGoal()
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = "ChecklistGoal";
        _goalName = "";
        _goalExplanation = "";
        _addPoints = 0;
        _finishedBonusPoints = 0;
        _goalFinishedCounts = 0;

    }
    private int _goalFinishedCounts; // How many times does it take to finish this goal
    private int _currentFinisedCounts = 0; // The current finished times of this goal
    private int _finishedBonusPoints;

    public int GetGoalFinishedCounts()
    {
        return _goalFinishedCounts;
    }

    public void SetGoalFinishedCounts()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        _goalFinishedCounts = GetValidInt();
    }

    public int GetFinishedBonusPoints()
    {
        return _finishedBonusPoints;
    }

    public void SetFinishedBonusPoints()
    {
        Console.WriteLine("What is the bonus points for accomplishing this goal?");
        _finishedBonusPoints = GetValidInt();
        
    }

    public int GetCurrentFinisedCounts()
    {
        return _currentFinisedCounts;
    }

    public void SetCurrentFinisedCounts()
    {
        // when user choose record goal event, invoke it
        _currentFinisedCounts++;
    }
    public override string AppendGoalToList()
    {
        // Append the goal to the list of simple goals
        string checklistGoalList = $"{_goalType}:{_goalName}, {_goalExplanation}, {_addPoints}, {_finishedBonusPoints}, {_goalFinishedCounts}, {_currentFinisedCounts}";

        return checklistGoalList;
    }

    public override string DisplayGoalList()
    {
        string finishedMark = "[ ]";
        if (_currentFinisedCounts == _goalFinishedCounts)
        {
            finishedMark = "[X]";
        }
        return $"{finishedMark} {_goalType}: {_goalName}, {_goalExplanation}, Current Progress: {_currentFinisedCounts}/{_goalFinishedCounts}";
    }
    
    public override int GetPlusPoint(int totalPoint)
    {
        totalPoint += _addPoints;
        return totalPoint;
    }

    public override void LoadFileGoalInfo(string[] lines)
    {
        _goalName = lines[0].Substring(14); // get the 1st item without the top 14 characters
        _goalExplanation = lines[1];
        _addPoints = int.Parse(lines[2]);
        _finishedBonusPoints = int.Parse(lines[3]);
        _goalFinishedCounts = int.Parse(lines[4]);
        _currentFinisedCounts = int.Parse(lines[5]);
    }

    public override int RecordGoalProcess(int totalPoints) // return the correct total points
    {
        if (_currentFinisedCounts < _goalFinishedCounts)
        {   
            totalPoints = GetPlusPoint(totalPoints);
            Console.WriteLine($"Congratulations! You have earned {_addPoints} points!");
            _currentFinisedCounts++;
            if (_currentFinisedCounts == _goalFinishedCounts)
            {
                totalPoints += _finishedBonusPoints;
                Console.WriteLine($"Extra bonus {_finishedBonusPoints} points for achieving the goal!");
            }
            return totalPoints;
        }
        else
        {
            Console.WriteLine($"You've already finished this goal. Please try to achieve other goals or create new ones.");
            return 0;
        }
    }

}