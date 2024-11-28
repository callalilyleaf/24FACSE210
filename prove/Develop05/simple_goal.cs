using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalType)
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = goalType;
        SetGoalName();
        SetGoalExplanation();
        SetAddPoints();
    }
    public SimpleGoal() // for loading goals usage
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = "SimpleGoal";
        _goalName = "";
        _goalExplanation = "";
        _addPoints = 0;
        _isSimpleGoalFinished = false;
    }
    private bool _isSimpleGoalFinished = false;

    public override string AppendGoalToList()
    {
        // Append the goal to the list of simple goals
        string simpleGoalList = $"{_goalType}:{_goalName}, {_goalExplanation}, {_addPoints}, {_isSimpleGoalFinished}";

        return simpleGoalList;
    }

    public override string DisplayGoalList()
    {
        string finishedMark = "[ ]";
        if (_isSimpleGoalFinished)
        {
            finishedMark = "[X]";
        }
        return $"{finishedMark} {_goalType}: {_goalName}, {_goalExplanation}";
    }

    public override int GetPlusPoint(int totalPoint)
    {
        totalPoint += _addPoints;
        return totalPoint;
    }

    public override void LoadFileGoalInfo(string[] lines)
    {
        _goalName = lines[0].Substring(11); // get the 1st item without the top 11 characters (SimpleGoals:)
        _goalExplanation = lines[1];
        _addPoints = int.Parse(lines[2]);
        _isSimpleGoalFinished = bool.Parse(lines[3]);
    }
    
    public override int RecordGoalProcess(int totalPoints) // return the correct total points
    {   
        if (!_isSimpleGoalFinished)
        {   
            totalPoints = GetPlusPoint(totalPoints);
            Console.WriteLine($"Congratulations! You have earned {_addPoints} points!");
            _isSimpleGoalFinished = true;
            return totalPoints;
        }
        else
        {
            Console.WriteLine($"You've already finished this goal. Please try to achieve other goals or create new ones.");
            return 0;
        }
    }

}