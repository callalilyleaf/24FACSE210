using System;

public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";
    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"This {_topic} assignment belongs to {_studentName} ";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void ChangeStudentName(string newName)
    {
        _studentName = newName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void ChangeTopic(string newTopic)
    {
        _topic = newTopic;
    }
}
