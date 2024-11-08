using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    protected string GetSummary()
    {
        string summary = _studentName + _topic;
        return summary;
    }
}