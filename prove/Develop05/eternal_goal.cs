public class EternalGoal : Goal
{
    public EternalGoal(string goalType)
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = goalType;
        SetGoalName();
        SetGoalExplanation();
        SetAddPoints();
    }

    public EternalGoal() // for loading goals usage
    {
        //string goalTypeName, string goalExplanaiton, int eachTimePoints
        _goalType = "EternalGoal";
        _goalName = "";
        _goalExplanation = "";
        _addPoints = 0;
    }

    public override string AppendGoalToList()
    {
        // Append the goal to the list of simple goals
        string eternalGoalList = $"{_goalType}:{_goalName}, {_goalExplanation}, {_addPoints}";

        return eternalGoalList;
    }

    public override string DisplayGoalList()
    {
        return $"    {_goalType}: {_goalName}, {_goalExplanation}";
    }

    public override int GetPlusPoint(int totalPoint)
    {
        totalPoint += _addPoints;
        return totalPoint;
    }

    public override void LoadFileGoalInfo(string[] lines)
    {
        _goalName = lines[0].Substring(12); // get the 1st item without the top 12 characters (EternalGoals:)
        _goalExplanation = lines[1];
        _addPoints = int.Parse(lines[2]);
    }
    
    public override int RecordGoalProcess(int totalPoints) // return the correct total points
    {  
        totalPoints = GetPlusPoint(totalPoints);
        Console.WriteLine($"Congratulations! You have earned {_addPoints} points!");
        return totalPoints;
    
    }

}